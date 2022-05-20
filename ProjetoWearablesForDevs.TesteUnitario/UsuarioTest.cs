using Xunit;
using ProjetoWearablesForDevs.Lib;

namespace ProjetoWearablesForDevs.TesteUnitario;

public class UsuarioTest
{
    [Fact]
    public void TestandoSeUsuarioSalvaNomeCorretamente()
    {
        //Arrange - Preparando
        var nomeEsperado = "Jonatan";
        var usuarioTest = new Usuario(nomeEsperado, "email@email.com", "senhamuitolouca");
        //Act - Agindo
        var nomeATestar = usuarioTest.GetNome();
        //Assert - 
        Assert.Equal(nomeEsperado, nomeATestar);
    }
    [Fact]
    public void TestandoSeUsuarioSalvaEmailCorretamente()
    {
        //Arrange - Preparando
        var emailEsperado = "email@email.com";
        var usuarioTest = new Usuario("Jonatan", emailEsperado, "senhamuitolouca");
        //Act - Agindo
        var emailATestar = usuarioTest.GetEmail();
        //Assert - 
        Assert.Equal(emailEsperado, emailATestar);
    }
    [Fact]
    public void TestandoSeUsuarioSalvaSenhaCorretamente()
    {
        //Arrange - Preparando
        var senhaEsperada = "senhamuitolouca";
        var usuarioTest = new Usuario("Jonatan", "email@email.com", senhaEsperada);
        //Act - Agindo
        var senhaAtestar = usuarioTest.GetSenha();
        //Assert - 
        Assert.Equal(senhaEsperada, senhaAtestar);
    }
    [Fact]
    public void TestandoSeAdminSalvaCNPJCorretamente()
    {
        //Arrange - Preparando
        var cnpjEsperado = "1234567890";
        var usuarioTest = new Admin("Jonatan", "email@email.com", "senhamuitolouca", cnpjEsperado);
        //Act - Agindo
        var cnpjATestar = usuarioTest.GetCNPJ();
        //Assert - 
        Assert.Equal(cnpjEsperado, cnpjATestar);
    }
    [Fact]
    public void TestandoSeClienteSalvaCPFCorretamente()
    {
        //Arrange - Preparando
        var cpfEsperado = "Jonatan";
        var usuarioTest = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", cpfEsperado, "Rua A");
        //Act - Agindo
        var cpfATestar = usuarioTest.GetCPF();
        //Assert - 
        Assert.Equal(cpfEsperado, cpfATestar);
    }
    [Fact]
    public void TestandoSeClienteSalvaEnderecoCorretamente()
    {
        //Arrange - Preparando
        var enderecoEsperado = "Rua A";
        var usuarioTest = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", enderecoEsperado);
        //Act - Agindo
        var enderecoATestar = usuarioTest.GetEndereco();
        //Assert - 
        Assert.Equal(enderecoEsperado, enderecoATestar);
    }
}