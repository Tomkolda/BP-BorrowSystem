namespace Půjčovna.Data.Shared
{
    public class MyThingContainer
    {
        public Things_To_Borrow thing {  get; set; }
        public List<int> category { get; set; }
        public void SetValue(Things_To_Borrow things)
        {
            this.thing = things;
        }
    }
}
