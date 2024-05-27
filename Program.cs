using Autofac;
using Estudo.AutoFac.Services;

/*cria uma instância do container buider do AutoFac*/
var builder = new ContainerBuilder();

/*Registro os tipos da classe concreta com as interfaces(IoC)*/
builder.RegisterType<SmsService>().As<IMobileService>();
builder.RegisterType<EmailService>().As<IMailService>();

/*cria uma instancia do container com o buider*/
var container = builder.Build();

/*Resolve os objeos chamando os métodos*/
container.Resolve<IMobileService>().Execute();
container.Resolve<IMailService>().Execute();

Console.ReadKey();