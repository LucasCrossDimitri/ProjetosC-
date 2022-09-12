using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabClassesClawer
{
    class Usuario
    {
        private string nome, email,endereco ;
        private float telefone, cpf;
        DateTime dataNasc;


    //Metodo construtor
    public Usuario()
    {
        this.nome = "";
        this.endereco = "";
        this.cpf = 0;
        this.email = "";
        this.telefone = 0;

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
    public void setCpf(float paramCpf)
    {
        this.cpf = paramCpf;
    }
    public void setEmail(string paramEmail)
    {
        this.email = paramEmail;
    }
    public void setTelefone(int paramTelefone)
    {
        this.telefone = paramTelefone;
    }
    public void setDataNasc(DateTime paramDataNasc)
    {
        this.dataNasc = paramDataNasc;
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
    public float getCpf()
    {
        return this.cpf;
    }
    public string getEmail()
    {
        return this.email;
    }
    public float getTelefone()
    {
        return this.telefone;
    }
    public DateTime getDataNasc()
    {
        return this.dataNasc;
    }





    }
}
