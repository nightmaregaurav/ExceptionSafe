# ExceptionSafe

![GitHub](https://img.shields.io/github/license/nightmaregaurav/ExceptionSafe)

ExceptionSafe is a utility library for swallowing exceptions.

## Usage
1. Install the package from [NuGet](https://www.nuget.org/packages/nightmaregaurav.exceptionsafe/).
```csharp
using ExceptionSafe;

// rest of the codes...
//
var mayFail = () => _get<T>(key);
return mayFail.ExceptionSafeExecute(); // will not fail instead returns default value if failed
//
// rest of the codes...
```

## License

ExceptionSafe is released under the MIT License. You can find the full license details in the [LICENSE](LICENSE) file.

Made with ❤️ by [NightmareGaurav](https://github.com/nightmaregaurav).

---
Open For Contribution
---
