# Monthly Fanart Maker

![](https://i.imgur.com/arVGftD.png)

O **Monthly Fanart Maker** é um pequeno utilitário em **Visual C#**(Windows Forms) feito para auxiliar na formatação de coletâneas de usuários(e suas respectivas artes) para fóruns que utilizam **BBCode**, mais especificamente o fórum da empresa de jogos [Atelier 801](https://atelier801.com/index), conhecida pelo jogo em Flash [Transformice](https://www.transformice.com). 
O fórum em questão tem coletâneas de desenhos feitos por fãs(Fanarts) postadas mensalmente, e para automatizar a formatação do tópico esta aplicação foi criada.

Embora contruída especialmente para tal fórum, também é possível utilizar ela para criar tabelas de coletânea para outros fóruns, desde que suportem tabelas em BBCode. Os templates são facilmente editáveis, em .txt.

## 🎨 Como Funciona

Artistas são adicionados pelo painel **Add Fanart**, incluindo a rede social a qual pertencem(que pode incluir o próprio fórum), um link para o post da rede social onde o desenho foi postado e uma pequena miniatura 130x130 que represente seu desenho.
No painel DataGridView à direita é possível visualizar os artistas adicionados e editar ou apagar uma entrada, caso necessário.
Após 15 artes serem adicionadas, é possível clicar em **Generate BBCode**. O programa formatará o tópico utilizando um arquivo .txt como template e copiará o conteúdo para a área de transferência, para ser colado na criação do tópico.

Como dito anteriormente, é possível utilizar este programa para criar coletâneas de arte ou usuários para qualquer fórum! Basta editar o arquivo bbtemplate.txt, onde a tabela formatada é representada por {0}.

## 🔧 Próximos passos

Embora o programa já seja funcional, ainda é possível expandí-lo. As mudanças abaixo podem ser implementadas por mim no futuro, mas contribuições também são muito bem vindas.

- [ ] README.md em inglês;
- [ ] Uma maneira de exportar e importar entradas na forma de arquivos de texto;
- [ ] Adicionar um template alternativo que utilize Markdown em vez de BBCode, para que possa ser utilizado em mais lugares.
