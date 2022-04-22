# Design Patterns
Padrões de projeto (design patterns) são soluções típicas para problemas comuns em projeto de software. Cada padrão é como uma planta de construção que você pode customizar para resolver um problema de projeto particular em seu código.

# Strategy
## O Strategy é um padrão de projeto comportamental que transforma um conjunto de comportamentos em objetos e os torna intercambiáveis dentro do objeto de contexto original.

O objeto original, chamado contexto, mantém uma referência a um objeto strategy e o delega a execução do comportamento. Para alterar a maneira como o contexto executa seu trabalho, outros objetos podem substituir o objeto strategy atualmente vinculado por outro.

<div align="center">
  <img src="https://user-images.githubusercontent.com/8028269/164507898-ca59b7d5-105d-434b-840d-7310273cbcf2.png"/>
</div>
<div align="center">
  <a href="https://github.com/mauriciomarcos/design-patterns/tree/main/DesignParttensSolution/src/Strategy">Código implementação do Pattnen Strategy</a>
</div>

# Singleton
## O Singleton é um padrão de projeto criacional que permite a você garantir que uma classe tenha apenas uma instância, enquanto provê um ponto de acesso global para essa instância.

Utilize o padrão Singleton quando uma classe em seu programa deve ter apenas uma instância disponível para todos seus clientes; por exemplo, um objeto de base de dados único compartilhado por diferentes partes do programa.
O padrão Singleton desabilita todos os outros meios de criar objetos de uma classe exceto pelo método especial de criação. Esse método tanto cria um novo objeto ou retorna um objeto existente se ele já tenha sido criado.

<div align="center">
  <img src="https://user-images.githubusercontent.com/8028269/164707208-03f5c793-94a4-42a2-b1f6-43ac3488e6c0.png"/>
</div>
<div align="center">
  <a href="https://github.com/mauriciomarcos/design-patterns/tree/main/DesignParttensSolution/src/Singleton">Código implementação do Pattnen Singleton</a>
</div>

# Factory Method
## O Factory method é um padrão de projeto criacional, que resolve o problema de criar objetos de produtos sem especificar suas classes concretas.

O Factory Method define um método, que deve ser usado para criar objetos em vez da chamada direta ao construtor (operador new). As subclasses podem substituir esse método para alterar a classe de objetos que serão criados.

<div align="center">
  <img src="https://user-images.githubusercontent.com/8028269/164765728-fee8798b-4b81-4e43-b91d-5a854fd27382.png"/>
</div>
<div align="center">
  <a href="https://github.com/mauriciomarcos/design-patterns/tree/main/DesignParttensSolution/src/FactoryMethod">Código implementação do Pattnen Factory Method</a>
</div>
