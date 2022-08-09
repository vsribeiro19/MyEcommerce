namespace Api.Data
{
    public class Item
    {

        public int IdItem { get; set; } = 0;
        public string Descricao { get; set; } = string.Empty;
        public string Link { get; set; }
        public float Valor { get; set; } = float.MinValue;
        public int QtdItem { get; set; } = int.MinValue;
    }
}
