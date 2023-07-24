namespace IcoCraft.backend.EventHandlers.Subscribers
{
    internal class CraftOperator
    {
        public void OnCraft(string pngPath, string craftedIconName)
        {
            if (pngPath == string.Empty)
            {
                // MessageBox
                return;
            }

            if (craftedIconName == string.Empty)
            {
                // MessageBox
                return;
            }

            // Code goes here
        }
    }
}
