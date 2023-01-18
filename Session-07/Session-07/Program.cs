// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Session_07;

ActionRequest request = new ActionRequest(Guid.NewGuid(),ActionEnum.Reverse, "bjfgth jhfn kgkh");

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);
resolver.Logger.ReadAll();

Console.ReadLine();
//Console.WriteLine(response.Output);
//resolver.Execute(request);