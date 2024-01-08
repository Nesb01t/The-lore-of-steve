namespace Player.Inventory
{
    public class InventoryClick
    {
        private EventHandler _handler;

        public InventoryClick()
        {
            _handler = new EventHandler();
        }

        public void Fire()
        {
            _handler.HandleEvent(new MicroEvent("InventoryClick"));
        }
    }
}