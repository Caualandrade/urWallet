using urWallet.BLL;
using urWallet.MODEL;

Usuario user = new Usuario();

//user.user = "gutinho@gmail.com";
//user.Senha = "abc123";

user.user = "caua@gmail.com";
user.Senha = "abc";
user.Saldo = (decimal?)0.0;


Boolean ver = UsuarioRepository.verificarUsuario(user);
Console.WriteLine(ver);


// UsuarioRepository usuarios = new UsuarioRepository();
//usuarios.Add(user);
//Console.WriteLine("Usuario add");




