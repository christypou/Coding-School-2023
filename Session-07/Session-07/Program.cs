// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Session_07;

ActionRequest request = new ActionRequest(Guid.NewGuid(),ActionEnum.Convert, "8");

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);
Console.WriteLine(response.Output);
//resolver.Execute(request);