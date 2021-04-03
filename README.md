# Name-Generator
A small library for generating names and gamertags.

### Generating Real Names

We have a list of first and last names that get randomly mashed together and returned, to generate real names, refer to the following code:

```csharp
NameGenerator Generator = new NameGenerator();
Generator.Generate();
```

Create an instance of the `NameGenerator` class, and simply call the `Generate()` method, and this will return the generated string


### Generating Gamertags

We have a list of first and last names that get randomly mashed together and returned, to generate real names, refer to the following code:

```csharp
GamerTagGenerator Generator = new GamerTagGenerator();
Generator.Generate();
```

Create an instance of the `GamerTagGenerator` class, and simply call the `Generate()` method, and this will return the generated string
