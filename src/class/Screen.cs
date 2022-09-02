class Screen
{
  private ConsoleColor backgroundColor;
  private ConsoleColor textColor;

  public Screen(ConsoleColor background, ConsoleColor text)
  {
    this.backgroundColor = background;
    this.textColor = text;

    this.setUpScreen();
  }

  public Screen()
  {
    this.backgroundColor = ConsoleColor.Black;
    this.textColor = ConsoleColor.Green;

    this.setUpScreen();
  }

  public void clear()
  {
    Console.Clear();
  }

  private void resetArea(int initialColumn, int initialRow, int finalColumn, int finalRow)
  {
    int column, row;

    for (column = initialColumn; column <= finalColumn; column++)
    {
      for (row = initialRow; row <= finalRow; row++)
      {
        this.insert(column, row, " ");
      }
    }
  }

  public void buildFrame(int initialColumn, int initialRow, int finalColumn, int finalRow)
  {
    int column, row;

    this.resetArea(initialColumn, initialRow, finalColumn, finalRow);

    for (column = initialColumn; column <= finalColumn; column++)
    {
      this.insert(column, initialRow, "-");
      this.insert(column, finalRow, "-");
    }

    for (row = initialRow; row <= finalRow; row++)
    {
      this.insert(initialColumn, row, "|");
      this.insert(finalColumn, row, "|");
    }

    // Insert `+` signal in the frame corners.
    this.insertSymbolInCorners(initialColumn, initialRow, finalColumn, finalRow);
  }

  private void insertSymbolInCorners(int initialColumn, int initialRow, int finalColumn, int finalRow)
  {
    this.insertSymbol(initialColumn, initialRow); // Superior left corner.
    this.insertSymbol(initialColumn, finalRow); // Superior right corner.
    this.insertSymbol(finalColumn, initialRow); // Inferior left corner.
    this.insertSymbol(finalColumn, finalRow);  // Inferior right corner.
  }

  private void insertSymbol(int x, int y)
  {
    this.insert(x, y, "+");
  }

  public void insert(int x, int y, string text)
  {
    Console.SetCursorPosition(x, y);
    Console.Write(text);
  }

  public string showMenu(List<string> options, int initialColumn, int initialRow)
  {
    string? option;
    int finalColumn, finalRow, counter;

    finalColumn = initialColumn + (options[0].Count() + 1);
    finalRow = initialRow + (options.Count() + 2);

    this.buildFrame(initialColumn, initialRow, finalColumn, finalRow);

    for (counter = 0; counter < options.Count(); counter++)
    {
      this.insert(initialColumn + 1, initialRow + counter + 1, options[counter]);
    }

    this.insert(initialColumn + 1, initialRow + counter + 1, "Opção: ");

    option = Console.ReadLine();

    if (option == null) {
      option = "0";
    }

    return option;
  }

  public void setUpScreen()
  {
    Console.BackgroundColor = this.backgroundColor;
    Console.ForegroundColor = this.textColor;

    this.clear();
  }
}
