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
