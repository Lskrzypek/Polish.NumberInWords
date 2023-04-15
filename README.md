# Polish.NumberInWords
Friendly library to convert an amount to Polish words in specified currency. 

```c
Console.WriteLine(25.20.ToCurrencyPolishWords());

// dwadzieścia pięć złotych i dwadzieścia groszy
```

Polish.NumberInWords offers following features:

### Specified currency

```c
25.20.ToCurrencyPolishWords(Currency.USD);

// dwadzieścia pięć dolarów i dwadzieścia centów
```

### All 7 Polish cases declension: Nominative, Genitive, Dative, Accusative, Instrumental, Locative, Vocative

```c
25.20.ToCurrencyPolishWords()
    .Case(Case.Genitive));

// dwudziestu pięciu złotych i dwudziestu groszy
```

### Configure text format
dwudziestu pięciu zł (PLN)

```c
25.20.ToCurrencyPolishWords()
    .Case(Case.Genitive)
    .Write(x => $"{x.MainUnitAmountInWords} {x.CurrencySymbol} ({x.CurrencyISO})");
    
 // dwudziestu pięciu zł (PLN)
```

## Others
See my others libraries:
- [Polish.CurrenciesInWords](https://github.com/Lskrzypek/Polish.CurrenciesInWords)
- [Polish.DatesInWords](https://github.com/Lskrzypek/Polish.DatesInWords)
