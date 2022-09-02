string option;

List<string> options = new List<string>();
options.Add("1 - Cadastro de Clientes");
options.Add("2 - Cadastro de Contas  ");
options.Add("3 - Registrar Movimento ");
options.Add("4 - Emitir Extrato      ");
options.Add("0 - Sair do Sistema     ");

Screen screen = new Screen(ConsoleColor.Black, ConsoleColor.White);
Clients clients = new Clients(screen);

while (true)
{
  screen.buildFrame(0, 0, 79, 24);
  option = screen.showMenu(options, 4, 2);

  if (option == "0") {
    break;
  }

  if (option == "1") {
    clients.executeCRUD();
  }
}

screen.clear();
