using Semana03.Exercicio02.Hotel;
using Semana03.Livraria;
using Semana03.Livraria.Gerente;
using Semana03.Livraria.Interface;
using Semana03.Livraria.Service;

//    Console.WriteLine("Valor percentual: " + processo(120, 20));


//static double processo(double x, double y) //Alterar nome da função e parâmetros para algum mais explicativo, 
//                                           //e.g. calculaPercentual(double valor, double percentual){...}
//{
//    double resultado = 0;
//    resultado = x * (y / 100);
//    return resultado;
//    //Aqui pode-se reduzir para apenas uma linha fazendo o retorno direto do cálculo,
//    // dispensando a declaração de uma nova variável, e.g. return x * (y / 100);
//}

//Também pode ser usado uma arrow function da seguinte forma:
// static double calculaPercentual(double valor, double percentual) => valor * (percentual / 100)



//static void PrincipioResponsabilidadeUnica()
//{
//    Livro liv = new Livro("Clean code", "Uncle Bob", 1990, 68, "IIUBA644ca");
//    Fatura fat = new Fatura(liv, 3, 0.01, 0.01);

//    IPersistenciaFatura baixarArquivo = new PersistenciaFaturaArquivoService();
//    IPersistenciaFatura salvarFaturaNoBD = new PersistenciaFaturaBDService();
//    ImprimirFatura imp =new (fat);

//    baixarArquivo.SalvarFatura(fat);
//    imp.imprimirFatura();
//    salvarFaturaNoBD.SalvarFatura(fat);
//}

static void PrincipioOpenClosed()
{
    Livro liv = new Livro("Clean code", "Uncle Bob", 1990, 68, "IIUBA644ca");
    Fatura fat = new Fatura(liv, 3, 0.01, 0.01);
    ImprimirFatura imp = new(fat);
    PersistenciaArquivoService perArq = new PersistenciaArquivoService();
    PersistenciaBDService perBd = new PersistenciaBDService();

    GerenteDePersistencia gerente = new GerenteDePersistencia(perArq, perBd);
    gerente._iPersistenciaFatura.SalvarFatura(fat);
    gerente._iPersistenciaLivro.SalvarLivro(liv);
}

//PrincipioResponsabilidadeUnica();
//PrincipioOpenClosed();

Console.WriteLine(Hotel.ServicoHotel("A"));

    