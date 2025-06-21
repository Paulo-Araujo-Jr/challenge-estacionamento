# Estacionamento de Veículos (Console App .NET)

Este é um sistema simples de estacionamento de veículos feito em C# usando .NET 7/8, com interface no terminal.

Permite:

- Estacionar veículos com validação de placa (formatos antigos e novos)
- Listar veículos estacionados
- Calcular débito com base no tempo de permanência (R$ 3,00/hora _padrão_)
- Remover o veículo do pátio ao consultar o débito
- Alterar o valor do estacionamento

---

## 🛠️ Requisitos

- [.NET SDK 7.0 ou superior](https://dotnet.microsoft.com/en-us/download)

Verifique se o .NET está instalado com:

```bash
dotnet --version
```

---

## ▶️ Como executar o projeto

1. Clone ou copie este repositório:

```bash
git clone git@github.com:Paulo-Araujo-Jr/challenge-estacionamento.git
cd desafio
```

2. Compile e execute:

```bash
dotnet run
```

3. Siga as instruções no terminal.

---

<details>
  <summary>🔽CLIQUE AQUI PARA VER O QUE CADA FUNÇÃO REALIZA</summary>

## 💡 Exemplo de uso

```
Digite [1] Para estacionar um veículo
Digite [2] Para listar os veículos estacionados
Digite [3] Buscar débito de veículo por placa
Digite [4] Para mudar o valor da hora de estacionamento
Digite [5] Para sair
```


Ao digitar "1" o usuário vai poder adicionar a placa do veículo, não é necessário adicionar a hora de entrada, pois o sistema pega a hora atual. É possível adicionar veículos que tenham placas tanto tradicionais, (3 letras - 4 números) ou Mercosul (4 letras e 3 números). O usuário não consegue adicionar outra padrão de placa, e caso ele tente cadastrar um veículo que já está cadastrado, não será possível.

 Ao digitar "2" o usuário vai conseguir visualizar todos os veículos e dados, como por exemplo: placa, hora de entrada, tempo que o veículo passou estacionado e débito atual. (mesmo que o usuário adicione a placa dos veículos com letras minúsculas na função "1", o retorno será em maiúsculo) 

Ao digitar "3" o usuário pode colocar a placa do veículo, e assim, retira-lo da lista de veículos estacionados. O usuário verá todos os dados do veículo, como por exemplo: como: placa, hora de entrada, tempo que o veículo passou estacionado, e débito atual. 

Ao digitar "4" o usuário consegue mudar o valor da hora do estacionamento, que por padrão é R$ 3.00 (três reais). Será possível alterar o valor para qualquer número com 2 casas decimais.

Ao digitar "5" o usuário encerra o sistema.
</details>

---

## 📂 Estrutura do Projeto

```

├── Program.cs                  // Entrada principal do app
├── model/
│   ├── Estacionamento.cs      // Classe que gerencia os veículos
│   └── Veiculo.cs             // Classe do veículo
├── desafio.csproj            // Arquivo do projeto
```

---

## 📋 Formatos de Placa Suportados

- Antigo: `ABC-1234`
- Novo (Mercosul): `ABC1D23`

O sistema aceita letras minúsculas ou maiúsculas.

---

## 📄 Licença

Este projeto é apenas para fins educacionais.


```
   ---------------------------.
 `/""""/""""/|""|'|""||""|   ' \.
 /    /    / |__| |__||__|      |
/----------=====================|
| \  /V\  /    _.               |
|()\ \W/ /()   _            _   |
|   \   /     / \          / \  |-( )
=C========C==_| ) |--------| ) _/==] _-{_}_)
 \_\_/__..  \_\_/_ \_\_/ \_\_/__.__.
