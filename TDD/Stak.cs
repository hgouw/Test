namespace TDD
{
    public class Stak
    {
        public bool IsEmpty { get; set; } = true;

        public object Pop()
        {
            IsEmpty = true;
            return null;
        }

        public void Push(object item)
        {
            IsEmpty = false;
        }
    }
}