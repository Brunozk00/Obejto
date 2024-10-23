using orientacaoObjetos;

//Instanciando objetos das classes derivadas com construtores
Estudante estudante1 = new Estudante("Carlos", 20, "123456");
Professor professor1 = new Professor("Diana", 30, "Ciência da Computação");
Funcionario funcionario1 = new Funcionario("João", 28, "Analisa de Sistemas", 5000);

//Exibir as informações :
Console.WriteLine("Estudante:");
estudante1.ExibirInformacoes();

Console.WriteLine("\nProfessor: ");
professor1 .ExibirInformacoes();

Console.WriteLine("\nFuncionário: ");
funcionario1 .ExibirInformacoes();

