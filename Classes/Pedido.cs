namespace Classes.ListaExerciciosS3.Entidades
{
    public class Pedido
    {
        private DateTime dtPedido;
        private List<ItemPedido> itempedido;

        public DateTime DtPedido { get => dtPedido; set => dtPedido = value; }
        public List<ItemPedido> Itempedido { get => itempedido; set => itempedido = value; }
        public int QuantidadeItens()
        {
            if (itempedido == null)
            {
                return 0;
            }
            else 
            { 
                return itempedido.Count; 
            }
            
        }
        public double ValorTotal()
        {
            double valort = 0.00;
            foreach (var item in itempedido)
            {
                valort = valort + item.Valor;
            }
            return valort;
        }
        public void AdicionarItemPedido(ItemPedido itemPedido)
        {
            if (itempedido is null)
            {
                itempedido = new List<ItemPedido>();
            }

            itempedido.Add(itemPedido);
        }


    }
}
