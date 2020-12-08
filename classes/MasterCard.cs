namespace POO_Encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        //Atributos
        private int parcelas;

        //get e set
        public int Parcelas{
            get{return parcelas;} //pegar dados - leitura
            set{parcelas = value;} //inserir dados - escrita
        }

        //Metodos
        public string CompraComDesconto(){
            return "";
        }


    }//MasterCard
}