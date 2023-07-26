using IcoCraft.backend.Singletons;

namespace IcoCraft.backend.EventHandlers.Subscribers
{
    internal class CraftOperator
    {
        public void OnCraft(string pngPath, string craftedIconName)
        {
            if (pngPath == string.Empty)
            {
                MessageBox.Show("Entry must not be empty!", "PNG Path Entry Error");
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
