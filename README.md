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

O sistema aceita letras minúsculas ou maiúsculas, com ou sem hífen.

---

## 💡 Exemplo de uso

```
Digite [1] Para estacionar um veículo
Digite [2] Para listar os veículos estacoinados
Digite [3] Buscar débito de veículo por placa
Digite [4] Para mudar o valor da hora de estacionamento
Digite [5] Para sair
```

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
