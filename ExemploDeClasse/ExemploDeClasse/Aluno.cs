using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDeClasse
{
    class Aluno
    {
        private string nome,nomemae,nomepai;
        private string endereco;
        private float nota1, nota2, nota3, media,salario;
        private int advertencias;
        DateTime dataNasc;
    

    //Metodo construtor
    public Aluno()
    {
        this.nome = "";
        this.endereco = "";
        this.nota1 = 0;
        this.nota2 = 0;
        this.nota3 = 0;
        this.media = 0;
        this.salario = 0;
        this.nomemae = "";
        this.nomepai = "";
        this.advertencias = 0;

    dataNasc = DateTime.Today;
    }

    //Metodos Set's
        public void setNome(string paramNome)
        {
         this.nome = paramNome;
        }
        public void setEndereco(string paramEndereco)
        {
            this.endereco = paramEndereco;
        }
        public void setNota1(float paramNota1)
        {
             this.nota1 = paramNota1;
        }
        public void setNota2(float paramNota2)
        {
            this.nota2 = paramNota2;
        }
        public void setNota3(float paramNota3)
        {
            this.nota3 = paramNota3;
        }
        public void setDataNasc(DateTime paramDataNasc)
        {
            this.dataNasc = paramDataNasc;
        }
        public void setSalario(float paramSalario)
        {
            this.salario = paramSalario;
        }
        public void setNomemae(string paramNomeMae)
        {
            this.nomemae = paramNomeMae;
        }
        public void setNomepai(string paramNomePai)
        {
            this.nomepai = paramNomePai;
        }
        public void setAdvertencias(int paramAdvertencias)
        {
            this.advertencias = paramAdvertencias;
        }

    //Métodos Get's
    public string getNome()
    {
        return this.nome;
    }
    public string getEndereco()
    {
        return this.endereco;
    }
    public float getNota1()
    {
        return this.nota1;
    }
    public float getNota2()
    {
        return this.nota2;
    }
    public float getNota3()
    {
        return this.nota3;
    }
    public float getMedia()
    {
        return this.media;
    }
    public DateTime getDataNasc()
    {
        return this.dataNasc;
    }
    public float getSalario()
    {
        return this.salario;
    }
    public string getNomemae()
    {
        return this.nomemae;
    }
    public string getNomepai()
    {
        return this.nomepai;
    }
    public int getAdvertencias()
    {
        return this.advertencias;
    }
    
    //Método para calcular a média
    public float calculaMedia()
    {
        this.media = (this.nota1 + this.nota2 + this.nota3) / 3;
        return this.media;
        }
    }
}
