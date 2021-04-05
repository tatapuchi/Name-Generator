# Name-Generator
A small library for generating names and gamertags.

---

### Generating Real Names

We have a list of first and last names that get randomly mashed together and returned, to generate real names, refer to the following code:

```csharp
RealNameGenerator Generator = new RealNameGenerator();
Generator.Generate();
```

Create an instance of the `RealNameGenerator` class, and simply call the `Generate()` method, and this will return the generated string

---

### Generating Gamertags

I made a list of gamertags upon which certain operations are performed to create new ones, to generate gamertags, refer to the following code:

```csharp
GamerTagGenerator Generator = new GamerTagGenerator();
Generator.Generate();
```

Create an instance of the `GamerTagGenerator` class, and simply call the `Generate()` method, and this will return the generated string

---

### Space Characters
You can change whatever character you use as a space, for the `NameGenerator` class this is just a regular space, while for the `GamerTagGenerator` class this is an underscore

You can change this to whatever you want, simply change the property in your instance of whatever generator you are using

```csharp
RealNameGenerator Generator = new RealNameGenerator();
Generator.Space = "-";
//You are now using a hypen(dash) for instead of a space
```

---

### Generation Flags
There are also additional flags you can set in your generator, specifically `Numbers` and `Hashtag`, which result in a 1-3 digit number being appended to your string and a hastag coming before your string respectively. These are defined within the `NameTypes` enum in the `IGenerator` interface.
These may prove useful when generating gamertags.

```csharp
GamerTagGenerator Generator = new GamerTagGenerator();
Generator.GeneratorFlags |= IGenerator.NameTypes.Hashtag;
//Hashtags will now come before your gamertags, eg: #b01b
```
