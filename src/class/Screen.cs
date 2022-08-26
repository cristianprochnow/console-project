class Screen
{
  private ConsoleColor backgroundColor;
  private ConsoleColor textColor;

  public Screen(ConsoleColor background, ConsoleColor text)
  {
    this.backgroundColor = background;
    this.textColor = text;
  }

  public Screen()
  {
    this.backgroundColor = ConsoleColor.Black;
    this.textColor = ConsoleColor.Green;
  }

  public void buildFrame(int initialColumn, int initialRow, int finalColumn, int finalRow)
  {
    int column, row;

    for (column = initialColumn; column <= finalColumn; column++)
    {
      Console.SetCursorPosition(column, initialColumn);
      Console.Write("-");

      Console.SetCursorPosition(column, finalColumn);
      Console.Write("-");
    }

    for (row = initialRow; row <= finalRow; row++)
    {
      Console.SetCursorPosition(initialColumn, row);
      Console.Write("|");

      Console.SetCursorPosition(finalColumn, row);
      Console.Write("|");
    }
  }
}
