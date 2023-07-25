using IcoCraft.backend.Singletons;

namespace IcoCraft.backend.EventHandlers.Subscribers
{
    internal class CraftOperator
    {
        public void OnCraft(string pngPath, string craftedIconName)
        {
            if (pngPath == string.Empty)
            {
                MessageBox.Show("Must not be empty");
                return;
            }

            if (craftedIconName == string.Empty)
            {
                MessageBox.Show("Must not be empty");
                return;
            }

            try
            {
                IconConverterTool.Instance.ConvertToIcon(pngPath, craftedIconName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
