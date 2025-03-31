## Geometry Library

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

### Интеграция в существующий проект
**Способ 1: Ссылка на проект**
1. ПКМ на Solution → Add → Existing Project
2. Выберите GeometryLibrary.csproj
3. Добавьте Reference из вашего проекта


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


**Запуск тестов:**
- Через Test Explorer (Ctrl+E,T)
- Через контекстное меню тестового класса

