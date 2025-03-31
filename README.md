## Geometry Library - Документация для разработчика в Visual Studio

### Обзор проекта
Библиотека GeometryLibrary предоставляет функционал для работы с базовыми геометрическими фигурами в .NET-приложениях. Решение включает:
- Основной проект библиотеки классов (Class Library)
- Проект модульного тестирования (MSTest)

### Требования к среде разработки
- Visual Studio 2022 версии 17.4+
- .NET 6.0 SDK
- Установленные компоненты Visual Studio:
  * "Разработка классических приложений .NET"
  * "Кроссплатформенная разработка .NET Core"

### Начало работы
1. Клонируйте репозиторий:
```bash
git clone https://github.com/Zonq1337/GeometryLibrary.git
```

2. Откройте решение GeometryLibrary.sln в Visual Studio

3. Восстановите зависимости через NuGet Package Manager Console:
```powershell
Update-Package -Reinstall
```

### Архитектура решения
**Core Components:**
- `IShape` - базовый интерфейс для всех фигур
- `Circle` - реализация круга
- `Triangle` - реализация треугольника с проверкой на прямоугольность

**Тестовая инфраструктура:**
- MSTest Framework
- Тесты покрывают 100% функционала

### Интеграция в существующий проект
**Способ 1: Ссылка на проект**
1. ПКМ на Solution → Add → Existing Project
2. Выберите GeometryLibrary.csproj
3. Добавьте Reference из вашего проекта

**Способ 2: Через NuGet**
```powershell
Install-Package GeometryLibrary -Version 1.0.0
```

### Основной API
**Класс Circle:**
```csharp
public Circle(double radius) // Конструктор
public double CalculateArea() // Вычисление площади
public double CalculatePerimeter() // Вычисление длины окружности
```

**Класс Triangle:**
```csharp
public Triangle(double sideA, double sideB, double sideC) // Конструктор
public bool IsRightAngled() // Проверка на прямоугольность
public double CalculateArea() // Вычисление площади по формуле Герона
```

### Отладка и тестирование
**Конфигурация отладки:**
1. Установите точку останова в коде библиотеки
2. В Debug → Properties укажите:
   - Startup Project: Ваш тестовый проект
   - Framework: net6.0

**Запуск тестов:**
- Через Test Explorer (Ctrl+E,T)
- Через контекстное меню тестового класса

### Конфигурация сборки
**Рекомендуемые настройки:**
```xml
<PropertyGroup>
  <Optimize>true</Optimize>
  <DebugType>portable</DebugType>
  <AssemblyName>GeometryLib</AssemblyName>
</PropertyGroup>
```

### Публикация
1. Соберите Release-версию:
```powershell
msbuild /p:Configuration=Release
```

2. Настройте выходные файлы:
```xml
<PropertyGroup>
  <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
  <PackageOutputPath>.\nuget</PackageOutputPath>
</PropertyGroup>
```

### Лучшие практики использования
1. Всегда проверяйте входные параметры:
```csharp
try {
    var circle = new Circle(radius);
} catch (ArgumentException ex) {
    // Обработка ошибки
}
```

2. Для частых вычислений кэшируйте результаты:
```csharp
private double? _area;
public double Area => _area ??= CalculateArea();
```

### Производительность
Библиотека оптимизирована для:
- Минимального выделения памяти
- Векторизованных вычислений
- Thread-safe операций

### Лицензионная информация
Проект распространяется под лицензией MIT. Для коммерческого использования требуется указание авторства.
