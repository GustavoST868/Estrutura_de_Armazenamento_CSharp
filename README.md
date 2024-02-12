# Estrutura_de_Armazenamento_CSharp
Estrutura de armazenamento de dados em C#

Store and Analyze Data
Este é um algoritmo em C# que fornece uma classe chamada Store para armazenar e manipular dados de diferentes tipos, e uma classe chamada Analyze para realizar análises estatísticas sobre esses dados. Abaixo estão as principais funcionalidades e características do algoritmo:


Store Class


Atributos:

datatext: Lista de strings para armazenar dados do tipo texto.
datanumber: Lista de strings para armazenar dados do tipo número.
datacompound: Lista de strings para armazenar dados do tipo composto.


Métodos:

insert_filter(string data): Insere dados na classe, identificando automaticamente o tipo de dado e armazenando na lista apropriada.

remove(string data): Remove dados da classe com base no tipo de dado.

search(string data): Realiza uma busca na classe, identificando automaticamente o tipo de dado e informando se o dado foi encontrado.

get(string data): Retorna o dado da classe se encontrado, caso contrário, retorna nulo.

print(): Exibe os dados armazenados na classe, separados por tipo.

Outros Métodos:

save(string data): Método vazio (ainda não implementado).

Getdatatext(), Getdatanumber(), Getdatacompound(): Métodos para obter as listas de dados de texto, números e dados compostos, respectivamente.

CheckType Class

CheckTypeFunction(string data): Função que verifica o tipo de dado (número, texto ou composto) e retorna um código correspondente.

Analyze Class


Atributos :

datatextcopy: Lista de strings para armazenar cópia dos dados de texto.
datanumbercopy: Lista de strings para armazenar cópia dos dados numéricos.
datacompoundcopy: Lista de strings para armazenar cópia dos dados compostos.


Métodos:

media(): Calcula e retorna a média dos dados numéricos armazenados.
standardDeviation(): Método vazio (ainda não implementado) para calcular o desvio padrão dos dados numéricos.
frequency(): Método vazio (ainda não implementado) para calcular a frequência dos dados numéricos.


Program Class

Main(): Função principal que realiza testes utilizando as classes Store e Analyze. Insere dados na Store, imprime os dados e realiza a análise da média utilizando a classe Analyze.
