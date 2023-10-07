using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PedroNogueira_TI18N
{
    class Calculadora
    {
        //variaveis Globais
        private double num1;
        private double num2;

        //Método construtor > instancia as variáveis na memória do computador
        public Calculadora()
        {
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;
            num2 = 0; //boa pratica de programação

        }//fim do Método construtor

        //Métodos Modificadores = GET e SET
        public double ConsultarNum1 //unicos que não tem parenteses
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim consultar num1    
        public double ConsultarNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//fim consultar num2

        //métodos
        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2;
        }//fim Somar
        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum2;
        }//fim do subtrair
        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;    
        }//Fim Multiplicar
        public double Dividir()
        { 
            if(ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            }
            return ConsultarNum1 / ConsultarNum2;
        }//Fim dividir

    }//fim da classe
}//fim do projeto
