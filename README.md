# StoreBox   

StoreBox é um projeto desenvolvido em C# utilizando Programação Orientada a Objetos (POO), que simula uma loja virtual com funcionalidades como gestão de produtos, pagamentos, contas de usuários e assinaturas.

O objetivo desse projeto é praticar os conceitos de POO adquiridos no curso Fundamentos da Orientação a Objetos, oferecido por <a href="https://github.com/balta-io">balta.io</a>.


## Tecnologias utilizadas

<img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge" alt=".NET Badge">
<img src="https://img.shields.io/badge/C%23-512BD4?style=for-the-badge" alt="CSharp Badge">



## Estrutura do projeto

### ProductContext
Gerencia os produtos da loja, incluindo itens físicos e digitais.


Product (classe abstrata): Classe base para todos os produtos.

DigitalProduct: Representa um produto digital.

PhysicalProduct: Representa um produto físico.




### PaymentContext
Responsável pelo sistema de pagamentos, permitindo diferentes formas de pagamento.

Payment (classe abstrata): Classe base para pagamentos.

BoletoPayment: Pagamento via boleto.

CreditCardPayment: Pagamento via cartão de crédito.

CryptoPayment: Pagamento via criptomoedas.

DebitCardPayment: Pagamento via cartão de débito.

PixPayment: Pagamento via PIX.

SubscriptionPayment: Pagamento de assinaturas recorrentes.


### AccountContext
Gerencia contas de usuários, separando compradores e vendedores.

Account (classe abstrata): Classe base para contas de usuários.

CustomerAccount: Conta de um cliente.

SellerAccount: Conta de um vendedor.


### SubscriptionContext
Gerencia assinaturas de serviços dentro da loja.

Subscription (classe abstrata): Classe base para assinaturas.

StorePrimeVideo: Classe de assinatura.


### CartContext

Gerencia o carrinho de compras e a lista de produtos adicionados.

Cart: Classe que representa o carrinho de compras.


## Pré-requisito

Certifique-se de ter o .NET 9.0 instalado em sua máquina. Você pode baixá-lo <a href="https://dotnet.microsoft.com/pt-br/download">aqui</a>.


## Para visualizar e executar
Clone o repositório:
```bash
git clone git@github.com:CostaDenis/Store-Box.git
```

Abra no Visual Studio Code:
```bash
code .
```

Com o projeto aberto no VSCode, abra o terminal com CTRL + ', e execute:
```bash
dotnet run
```










