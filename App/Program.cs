using Classes.ListaExerciciosS3.Entidades;
using Classes.ListaExerciciosS3.Repositorios;
// Exercício 2
/*
Menu menu = new Menu();
menu.NomePrato = "Ovo Frito";
menu.Ingredientes1.Add("ovo");
menu.Ingredientes1.Add("Azeite");
menu.Ingredientes1.Add("Sal");
menu.Preco = 12.55;
Console.WriteLine(menu.NomePrato);
Console.WriteLine(menu.Preco);

menu.ImprimirIngredientes();
*/

// Exercício 3
/*
AreaRetangulo area = new AreaRetangulo();
Console.Write("Insira o valor da base :");
area.Base= Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o valor da altura :");
area.Altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Valor da base : {area.Base}");
Console.WriteLine($"Valor da altura : {area.Altura}");
area.CalculaAreaRetangulo();

*/

// Exercício  4
/*
Pessoa pessoa = new Pessoa();
Pessoa pessoa1=new Pessoa();
pessoa1.Nome = "Pedro";
pessoa1.Idade = 19;
Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Afonso";
pessoa2.Idade = 45;
if (pessoa1.Idade > pessoa2.Idade) { pessoa = pessoa1; } else { pessoa = pessoa2; }
Pessoa pessoa3 = new Pessoa();
pessoa3.Nome = "Guilherme";
pessoa3.Idade = 31;
if (pessoa.Idade < pessoa3.Idade) pessoa = pessoa3;
pessoa.ExibirDados();
*/

// Exercício  5
/*

CalculadoraBasica calcula=new CalculadoraBasica();
Console.Write("Insira o Valor1 : ");
calcula.Valor1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o Valor2 : ");
calcula.Valor2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o Operador *,/,+,- : ");
calcula.Operacao = Console.ReadLine();
Console.Write($"O Resultado é : {calcula.Calcular()}");
*/
// Exercício  6
/*
Pedido pedido = new Pedido();
ItemPedido item1=new ItemPedido();
item1.Valor = 10.35;
item1.Nome = "Adesivo";
pedido.AdicionarItemPedido(item1);
ItemPedido item2 = new ItemPedido();
item2.Valor = 8.50;
item2.Nome = "Papel";
pedido.AdicionarItemPedido(item2);
ItemPedido item3 = new ItemPedido();
item3.Valor = 20.65;
item3.Nome = "Tesoura";
pedido.AdicionarItemPedido(item3);
Console.WriteLine($"Quantidade de itens do pedido é : {pedido.QuantidadeItens()}");
Console.WriteLine($"Valor total do pedido é : {pedido.ValorTotal()}");
*/
// Exercício  7

/*
RepositorioExame repo= new RepositorioExame();
Exame exame1 = new Exame();
exame1.Nome = "Kunegundes";
exame1.Nota = 55.68;
repo.AdicionarNotaExame(exame1);
Exame exame2 = new Exame();
exame2.Nome = "Valcredo";
exame2.Nota = 76.90;
repo.AdicionarNotaExame(exame2);
Exame exame3 = new Exame();
exame3.Nome = "Mefistófeles";
exame3.Nota = 80.00;
repo.AdicionarNotaExame(exame3);
repo.MaiorNota();
repo.MenorNota();
repo.MediaNota();
Console.WriteLine($" Número de Alunos Aprovados : {repo.NumReprovados()}");
*/

// Exercício  8
/*
RepositorioAluno repo= new RepositorioAluno();
Aluno aluno1 = new Aluno();
aluno1.Nome = "Mefistófeles";
aluno1.Turma = 1;
repo.AdicionarAluno(aluno1);
Aluno aluno2 = new Aluno();
aluno2.Nome = "Bagumira";
aluno2.Turma = 1;
repo.AdicionarAluno(aluno2); 
Aluno aluno3 = new Aluno();
aluno3.Nome = "Cornélia";
aluno3.Turma = 5;
repo.AdicionarAluno(aluno3); 
Aluno aluno4 = new Aluno();
aluno4.Nome = "Kunegunses";
aluno4.Turma = 5;
repo.AdicionarAluno(aluno4); 
Aluno aluno5 = new Aluno();
aluno5.Nome = "Praxedes";
aluno5.Turma = 2;
repo.AdicionarAluno(aluno5);
Aluno aluno6 = new Aluno();
aluno6.Nome = "Valcréia";
aluno6.Turma = 2;
repo.AdicionarAluno(aluno6);
Console.WriteLine("Lista em ordem Crescente");
repo.Ordena("ASC");
Console.WriteLine("Lista em ordem Decrescente");
repo.Ordena("DESC");
*/
//Exercicio 9
/*
RepositorioAnimal repo=new RepositorioAnimal();
Animal animal1=new Animal();
animal1.Nome = "Rex";
animal1.Tipo = "Cão";
repo.AdicionarAnimal(animal1);
Animal animal2 = new Animal();
animal2.Nome = "Cachorro";
animal2.Tipo = "Gato";
repo.AdicionarAnimal(animal2); 
Animal animal3 = new Animal();
animal3.Nome = "Nemo";
animal3.Tipo = "Peixe";
repo.AdicionarAnimal(animal3);
Console.WriteLine($" Número CAchorros : {repo.ContaCao()}");
*/
//Exercicio 10

Produto produto = new Produto();
produto.Valor = 1000.00;
produto.Nome = "Calça Jeans";
produto.Desconto = 10;
Console.WriteLine($"O produto {produto.Nome} custa {produto.Valor} e com desconto sai {produto.Valor*(100- Convert.ToDouble(produto.Desconto))/100}");