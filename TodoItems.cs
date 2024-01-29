namespace TodoAPI.Models
{

    //i am just putting this comment for changes 
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}