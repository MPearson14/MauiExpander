namespace TelerikMauiApp
{
    public static class HelperExtensions
    {
        public static int ToInt(this object value)
        {
            if (value is bool)
            { return (bool)value ? 1 : 0; }

            string? myValueString = value == null ? string.Empty : value.ToString();

            if (value is decimal)
            {
                int myIndex = myValueString?.IndexOf('.') ?? -1;

                if (myIndex >= 0)
                {
                    myValueString = myValueString?[..myIndex] ?? string.Empty;
                }
            }

            _ = int.TryParse(myValueString, out int myReturn);

            return myReturn;
        }
    }
}
