
namespace VSTDA.API.Models
{
    public class TodoItem
    {
        public int TodoItemId { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }
        public bool IsDone { get; set; }
    }
}