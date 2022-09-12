using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabClassesClawer
{
    class Produtos
    {
        private string nome, tipo, marca;
        private float idp, vavenda, vacompra, qtdm;

    

        //Metodo construtor
    public Produtos()
    {
        this.nome = "";
        this.tipo = "";
        this.marca = "";
        this.idp = 0;
        this.vavenda = 0;
        this.vacompra = 0;
        this.qtdm = 0;
    }

    //Metodos Set's
    public void setNome(string paramNome)
    {
        this.nome = paramNome;
    }
    public void setTipo(string paramTipo)
    {
        this.tipo = paramTipo;
    }
    public void setMarca(string paramMarca)
    {
        this.marca = paramMarca;
    }
    public void setIDP(float paramIDP)
    {
        this.idp = paramIDP;
    }
    public void setVaVenda(float paramVaVenda)
    {
        this.vavenda = paramVaVenda;
    }
    public void setVaCompra(float paramVaCompra)
    {
        this.vacompra = paramVaCompra;
    }
    public void setQtdm(float paramQtdm)
    {
        this.qtdm = paramQtdm;
    }

    //Métodos Get's
    public string getNome()
    {
        return this.nome;
    }
    public string getTipo()
    {
        return this.tipo;
    }
    public string getMarca()
    {
        return this.marca;
    }
    public float getIDP()
    {
        return this.idp;
    }
    public float getVaVenda()
    {
        return this.vavenda;
    }
    public float getVaCompra()
    {
        return this.vacompra;
    }
    public float getQtdm()
    {
        return this.qtdm;
    }



    }
}
