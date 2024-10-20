using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OnlineStore_WinformsUI.Models;

namespace OnlineStore_WinformsUI.Services
{
    internal class OrderGenerator
    {
        private readonly object _locker = new object();
        private readonly Random _random = new Random();
        private readonly ApiClient _client;
        private readonly ProgressBar _progressBar;

        public OrderGenerator(ApiClient apiClient, ProgressBar progressBar)
        {
            _client = apiClient;
            _progressBar = progressBar;
        }

        public async Task GenerateNewOrderItems(int orderCount)
        {
            string response = await _client.GetDataAsync("Pizza/GetAllPizza") ?? throw new InvalidOperationException("Can't get all pizzas.");
            List<Pizza> allPizzas = JsonConvert.DeserializeObject<List<Pizza>>(response) ?? throw new InvalidOperationException("Can't serialize all pizzas.");
            PizzaSize[] pizzaSizes = { PizzaSize.Small, PizzaSize.Medium, PizzaSize.Large };

            using SemaphoreSlim semaphore = new SemaphoreSlim(90);

            const int MaxCountOfSimultaneousTasks = 90;
            List<Task> tasks = new List<Task>();

            _progressBar.Maximum = orderCount;
            _progressBar.Value = _progressBar.Minimum;

            for (int i = 1; i <= orderCount; i++)
            {
                tasks.Add(RunGenerationAsync());

                if (tasks.Count >= MaxCountOfSimultaneousTasks)
                {
                    await Task.WhenAny(tasks);
                    tasks.RemoveAll(t => t.IsCompleted);
                }
            }

            await Task.WhenAll(tasks.ToArray());

            _progressBar.Value = _progressBar.Maximum;

            async Task RunGenerationAsync()
            {
                await Task.Delay(1); // To unblock UI

                await semaphore.WaitAsync();
                try
                {
                    string orderNumber = string.Empty;
                    int orderItemCount = _random.Next(1, 7);

                    for (int j = 1; j <= orderItemCount; j++)
                    {
                        OrderItem orderItem = new()
                        {
                            Pizza = allPizzas[_random.Next(allPizzas.Count)],
                            DoughType = (DoughType)_random.Next(1, 2),
                            OrderNumber = orderNumber,
                            PizzaCount = _random.Next(1, 5),
                            PizzaSize = pizzaSizes[_random.Next(pizzaSizes.Length)]
                        };

                        string jsonBody = System.Text.Json.JsonSerializer.Serialize(orderItem);

                        orderNumber = await _client.PostDataAsync("Order/AddCustomerOrderItem", jsonBody);
                    }

                    IncreaseProgressBarValue();
                }
                finally
                {
                    semaphore.Release();
                }

                void IncreaseProgressBarValue()
                {
                    lock (_locker)
                    {
                        if (_progressBar.InvokeRequired)
                        {
                            _progressBar.Invoke(() => _progressBar.Value++);
                        }
                        else
                        {
                            _progressBar.Value++;
                        }
                    }
                }
            }
        }

        public string GenerateNumber()
        {
            const int NumberLength = 8;
            const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(Chars, NumberLength)
                              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
