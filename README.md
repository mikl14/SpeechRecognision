# SpeechRecognision

SpeechRecognision - это .NET библиотека для распознавания речи, построенная на базе Vosk и NAudio.

## Особенности

- Все зависимости включены в библиотеку, дополнительной установке требует только NuGet-пакет **Vosk**.
- Взаимодействие с библиотекой осуществляется через единственный публичный класс **Recognizer**.
- Все остальные классы имеют уровень доступа `private` и не предназначены для прямого использования.

## Класс Recognizer

- Конструктор инициализирует модель Vosk по переданному пути к модели.
- Поддерживает настройку параметров распознавания:
  - `enableRusNumbers` - включение нативного распознавания русских числительных.
  - `enableWordToCode` - включение режима замены слов по словарю.

### Методы и события

- `setCodeDictionary(Dictionary<string, string> dictionary)` - задаёт словарь фраз для замены. В режиме `enableWordToCode` при распознавании ключи из словаря заменяются на соответствующие значения.
- `startRecording()` - начинает запись голоса с микрофона.
- `stopRecording()` - останавливает запись голоса.
- Событие `RecognitionResultReceived` - подписка на получение результатов распознавания в момент определения фразы.

## Вспомогательные классы (private)

- **Decoder** - статический класс, содержащий метод и словарь `Dictionary<string, string>`, отвечающий за замену фраз в режиме `enableWordToCode`.
- **RussianNumberParcer** - класс с методами для преобразования русских числительных в цифры.

---

Данная библиотека обеспечивает удобный интерфейс для офлайн-распознавания речи с поддержкой специфичных функций для русского языка, используя мощь Vosk и возможности NAudio для работы с аудио.
