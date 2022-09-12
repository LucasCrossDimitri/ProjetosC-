using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacaDoCarro
{
    class Carro
    {
        private string dono,cor,placa,modelo,idadeCarro;
        private int velocidade,limiteVelocidade;
        DateTime dataCompra;

        //Metodo Construtor
        public Carro()
        {
            this.dono = "";
            this.cor = "";
            this.placa = "";
            this.modelo = "";
            this.idadeCarro = "";
            this.velocidade = 0;
            this.limiteVelocidade = 0;
            dataCompra = DateTime.Today;
        }

        //Metodos Set's
        public void setDono(string paramDono)
        {
            this.dono = paramDono;
        }
        public void setCor(string paramCor)
        {
            this.cor = paramCor;
        }
        public void setPlaca(string paramPlaca)
        {
            this.placa = paramPlaca;
        }
        public void setModelo(string paramModelo)
        {
            this.modelo = paramModelo;
        }
        public void setIdadeCarro(string paramIdadeCarro)
        {
            this.idadeCarro = paramIdadeCarro;
        }
        public void setVelocidade(int paramVelocidade)
        {
            this.velocidade = paramVelocidade;
        }
        public void setLimiteVelocidade(int paramLimiteVelocidade)
        {
            this.limiteVelocidade = paramLimiteVelocidade;
        }
        public void setDataCompra(DateTime paramDataCompra)
        {
            this.dataCompra = paramDataCompra;
        }

        //Métodos Get's
        public string getDono()
        {
            return this.dono;
        }
        public string getCor()
        {
            return this.cor;
        }
        public string getPlaca()
        {
            return this.placa;
        }
        public string getModelo()
        {
            return this.modelo;
        }
        public string getIdadeCarro()
        {
            return this.idadeCarro;
        }
        public int getVelocidade()
        {
            return this.velocidade;
        }
        public int getLimiteVelocidade()
        {
            return this.limiteVelocidade;
        }
        public DateTime getDataCompra()
        {
            return this.dataCompra;
        }

        //metodo que verifica o limite de velo
        public bool verificarvelocidade()
        {
            if (this.velocidade > this.limiteVelocidade)
                return true;
            else
                return false;
        }
        //Metodo que calcula o tempo de uso do Carro
        public void CalculaTempoUso()
        {
            int ano = DateTime.Today.Year - dataCompra.Year;
            int mes = DateTime.Today.Year - dataCompra.Year;
            int dia = DateTime.Today.Year - dataCompra.Year;
            int hora = DateTime.Today.Year - dataCompra.Year;
            int minutos = DateTime.Today.Year - dataCompra.Year;
            this.idadeCarro = ano + "Anos(s)" + mes + "Mes(es)" + dia + "Dia(as)";
        }


    }
}
