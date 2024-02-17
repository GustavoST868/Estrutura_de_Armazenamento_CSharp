# Estrutura_de_Armazenamento_CSharp
Estrutura de armazenamento de dados em C#

**Descrição do Algoritmo:**

O algoritmo é uma implementação de um sistema de armazenamento (`Store`) e análise (`Analyze`) de dados. Ele utiliza classes para organizar diferentes funcionalidades, como inserção, remoção, busca, impressão, e salvamento de dados. Vamos descrever a função de cada classe e seus métodos:

### Classe `Store`:
Esta classe é responsável por armazenar dados e realizar operações básicas sobre esses dados.

#### Atributos:
- `datatext`: Lista de strings para armazenar dados do tipo texto.
- `datanumber`: Lista de strings para armazenar dados do tipo número.
- `datacompound`: Lista de strings para armazenar dados compostos.

#### Métodos:

1. `insert_filter(string data)`: Insere um dado na lista correspondente ao seu tipo (número, texto ou composto).
2. `remove(string data)`: Remove um dado da lista correspondente ao seu tipo.
3. `search(string data)`: Verifica se um dado está presente nas listas e imprime uma mensagem se encontrado.
4. `get(string data)`: Retorna o dado se estiver presente nas listas, caso contrário, retorna `null`.
5. `print()`: Imprime os dados armazenados, separados por tipo.
6. `save()`: Salva os dados em um arquivo no diretório atual.
7. `Getdatatext()`, `Getdatanumber()`, `Getdatacompound()`: Métodos para obter as listas de dados de texto, números e compostos, respectivamente.

### Classe `CheckType`:
Esta classe verifica o tipo de dado (número, texto ou composto) por meio de expressões regulares.

#### Métodos:
1. `CheckTypeFunction(string data)`: Retorna um código indicando o tipo do dado.

### Classe `Analyze`:
Esta classe realiza análises estatísticas sobre os dados armazenados na classe `Store`.

#### Atributos:
- `datatextcopy`: Lista de strings contendo cópia dos dados de texto da classe `Store`.
- `datanumbercopy`: Lista de strings contendo cópia dos dados de números da classe `Store`.
- `datacompoundcopy`: Lista de strings contendo cópia dos dados compostos da classe `Store`.

#### Métodos:

1. `media()`: Calcula a média dos dados numéricos.
2. `variance()`: Calcula a variância dos dados numéricos.
3. `standardDeviation()`: Calcula o desvio padrão dos dados numéricos.
4. `frequency(string datatext)`: Conta a frequência de um dado texto nas listas, considerando o tipo de dado.

### Classe `Program`:
O método `Main` contém testes das classes `Store` e `Analyze`, onde dados são inseridos na loja (`Store`), impressos, salvos em arquivo, buscados e, em seguida, análises estatísticas são realizadas com a classe `Analyze`.

Em resumo, o algoritmo fornece uma estrutura para armazenar, manipular e analisar diferentes tipos de dados, organizando as funcionalidades em classes específicas para facilitar a compreensão e manutenção do código.