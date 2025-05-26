# 🎯 Sistema de Gestão de Vendas com Estorno e Controle de Produtos

![C#](https://img.shields.io/badge/C%23-%23239120?style=flat&logo=c-sharp&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-%2307405e?style=flat&logo=sqlite&logoColor=white)
![Windows Forms](https://img.shields.io/badge/WinForms-%23000000?style=flat&logo=windows&logoColor=white)

---

## 📋 Sobre o projeto

Sistema completo de **gestão de vendas** desenvolvido em **C# com Windows Forms** e **SQLite**, com foco no controle de produtos, vendas, estornos, importação/exportação de dados e cadastro de marcas.

---

## 🖼️ Imagens do Sistema

### 🏠 Menu Principal
![Menu](./FotosVendaEstorno/Menu.png)

### 🛒 Cadastro de Produtos
![Produtos](./FotosVendaEstorno/Produto.png)

### 💰 Venda de Produtos
![Venda](./FotosVendaEstorno/Venda.png)

### ↩️ Estorno de Vendas
![Estorno](./FotosVendaEstorno/Estorno.png)

### 🔐 Tela de Login
![Login](./FotosVendaEstorno/Login.png)

---

## 🔧 Funcionalidades Principais

✅ Menu principal com navegação dinâmica entre formulários, evitando múltiplas instâncias  
✅ Estrutura modular em camadas: **DTO**, **DAL** e **BLL**  
✅ Persistência local de dados utilizando **SQLite**  
✅ Módulos independentes para:  
- Cadastro e pesquisa de **Produtos** e **Marcas**  
- Processamento de **Vendas** e **Estornos**  
- **Importação** e **Exportação** de arquivos  
- Tela de **Login** com autenticação de usuários  

---

## 🧠 Destaques Técnicos

- Utilização de **Generics com constraints** (`where T : Form, new()`) para abertura dinâmica de formulários  
- Gerenciamento de janelas aninhadas via **DockStyle.Fill** para uma interface limpa e intuitiva  
- Organização seguindo princípios de **Clean Code** e **SOLID**  

---

## 💻 Tecnologias Utilizadas

- **C#** (.NET Framework)
- **Windows Forms**
- **SQLite** (`System.Data.SQLite`)
- Arquitetura em **Camadas** (DTO, DAL, BLL)

---

## 📁 Estrutura do Projeto

```plaintext
📂 PrjVendaEstorno
 ├── 📂 code
 ├── 📂 Resources
 ├── frmCadastroMarca.cs
 ├── frmCadastroProdutos.cs
 ├── frmEstorno.cs
 ├── frmExportarArquivo.cs
 ├── frmImportarArquivo.cs
 ├── frmLogin.cs
 ├── frmMenu.cs
 ├── frmPesquisaMarca.cs
 ├── frmPesquisaProdutos.cs
 ├── frmVenda.cs
 ├── Program.cs
 └── SistemaVendas.ico
