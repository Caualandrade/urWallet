select Usuarios.usuario,financas.tipo, financas.categoria, sum(financas.valor) as total from financas join userFinanca
on financas.Id = userFinanca.id_financa join Usuarios on Usuarios.Id = userFinanca.id_user where Usuarios.Id = 1
group by Usuarios.usuario,financas.tipo, financas.categoria order by financas.tipo