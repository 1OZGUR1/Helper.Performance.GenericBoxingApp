# Boxing & Unboxing in C# - EN
Boxing and unboxing are common terms used in programming languages like C#, and they refer to the conversion between value types and reference types.

## Boxing
Boxing is the process of converting a value type (such as an int or double) to an object type (such as object). A value type variable is "boxed" into an object, and thus the value type variable can be used as an object type. However, this conversion process can cause performance loss because value types contain values directly, while objects contain references, which increases memory usage.

## Unboxing
Unboxing is the process of converting the value inside a boxed object to its original value type. In other words, it is the conversion from an object type (such as object) to a value type (such as int or double).

---
---
---

# Boxing & UnBoxing - TR

Boxing ve unboxing, genellikle C# gibi dillerde kullanılan terimlerdir ve genellikle değer tipleri ile referans tipleri arasında dönüşüm yapmayı ifade eder.

## Boxing
Boxing, bir değer tipini (örneğin, bir int veya double gibi) bir nesne tipine (object gibi) dönüştürme işlemidir. Değer tipi olan bir değişken, bir nesne içine "kutulanır" ve böylece değer tipi olan değişken nesne tipi olarak kullanılabilir. Ancak, bu dönüşüm işlemi performans kaybına neden olabilir çünkü değer tipleri değerleri doğrudan içerirken, nesneler referansları içerir ve bu da bellek kullanımını artırır.

- Örneğin, bir int'i bir nesne içine kutulamak için:
```Csharp
int num = 10;
object obj = num; // Boxing işlemi
```

## Unboxing
Unboxing, kutulanmış bir nesnenin içindeki değeri orijinal değer tipine dönüştürme işlemidir. Yani, bir nesne tipinden (object gibi) değer tipine (int veya double gibi) dönüştürme işlemidir.

- Örneğin, bir nesne içindeki değeri çıkarmak için:

```Csharp
object obj = 10; // Boxing yapılmış bir değer
int num = (int)obj; // Unboxing işlemi
```

## Önemli Not
Boxing ve unboxing, bazı durumlarda ihtiyaç duyulan işlemlerdir, ancak performans açısından maliyetli olabilirler. Bu nedenle, **gereksiz yere kullanılmamaları ve performans gereksinimleri göz önünde bulundurularak dikkatli bir şekilde kullanılmaları önemlidir**.

### Example
```Csharp
public class Example
{
    public static void Main()
    {
        string value = "Merhaba Dünya!";

        // Generic boxing with two type arguments
        var boxedValue = GenericBoxingUnboxing.Box<object, string>(value); // Specify both TBox and TValue

        // Generic unboxing
        string? unboxedValue = GenericBoxingUnboxing.Unbox<string>(boxedValue);

        Console.WriteLine(unboxedValue); // "Merhaba Dünya!" yazdırır
    }
}
```