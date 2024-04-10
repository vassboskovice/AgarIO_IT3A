using Newtonsoft.Json;

namespace AgarIO_IT3A.Shared.Core
{
    public class Game
    {
        public List<GameObject> gameObjects { get; }

        public Game()
        {
            gameObjects = new List<GameObject>();
        }

        public void AddGameObject(Player player)
        {
            gameObjects.Add(player);
        }

        public void AddGameObject(Food food)
        {
            gameObjects.Add(food);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Game? FromJson(string jsonData)
        {
            try
            {
                return JsonConvert.DeserializeObject<Game>(jsonData);
            }
            catch
            {
                return null;
            }
        }
    }
}