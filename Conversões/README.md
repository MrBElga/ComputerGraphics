# 📷 Projeto de Computação Gráfica em C#

Este repositório contém um projeto de computação gráfica desenvolvido em **C#**, abordando diversas funcionalidades para manipulação de imagens. O foco principal é a conversão de cores e ajustes de luminância, proporcionando ferramentas úteis para análise e transformação de imagens.

## ✨ Funcionalidades

- **Luminância:** Ajuste do brilho da imagem utilizando **DMA (Diferença de Módulo Absoluto)**.
- **Negativo da Imagem:** Geração do negativo da imagem através da inversão dos valores de cor.
- **Conversões de Cores:**
  - **RGB para CMY:** Conversão do espaço de cores **RGB** para **CMY**.
  - **RGB para HSI:** Conversão do espaço de cores **RGB** para **HSI** com base em fórmulas matemáticas.
  - **Miniaturas de Canais:** Geração de miniaturas da imagem para os canais **R, G, B, H, S, I**.
- **Ajuste de Brilho:** Controle deslizante para aumentar ou reduzir o brilho da imagem.
- **Mudança de Matiz:** Alteração seletiva da matiz (**Hue**) da imagem, com foco em tons de azul.

## 🛠 Como Usar

### 1️⃣ Clonar o Repositório
```bash
git clone https://github.com/seu-usuario/nome-do-repositorio.git
```

### 2️⃣ Abrir o Projeto
Abra o projeto no **Visual Studio** ou em sua **IDE** preferida.

### 3️⃣ Executar a Aplicação
- Compile e execute o projeto.
- Utilize a interface gráfica para carregar imagens e aplicar as transformações disponíveis.

## 📌 Exemplos de Uso

- **Conversão RGB para HSI**
  - Carregue uma imagem e selecione a opção de conversão **RGB → HSI**.
  - Passe o mouse sobre a imagem para visualizar os valores **RGB, CMY e HSI**.

- **Ajuste de Brilho**
  - Aumente o brilho da imagem em **40%** para destacar detalhes específicos.

- **Mudança de Matiz**
  - Modifique a matiz para **-30°**, ajustando os tons azulados na imagem.

## 📚 Referências
- Para detalhes matemáticos sobre conversões de cores, consulte: [RGB to HSI](RGB_to_HSI.pdf)
- Para mais informações sobre cálculos de cores, visite: [Color Calculator](http://drpeterjones.com/colorcalc/)

## 🤝 Contribuição
Contribuições são bem-vindas! Caso tenha sugestões, abra uma **issue** ou envie um **pull request** para ajudar a melhorar o projeto.

## 📜 Licença
Este projeto está licenciado sob a **MIT License** - consulte o arquivo **LICENSE** para mais detalhes.
