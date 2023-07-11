using Lab2;
namespace Lab2_ATM_Test;

public class UnitTest1
{
    [Theory]
    [InlineData("12")]
    [InlineData("22")]
    [InlineData("15")]
    [InlineData("2000")]
    [InlineData("1000")]
    public void ViewBalanceTest(string balance)
    {
        var deciamalBalance = Convert.ToDecimal(balance);
       Assert.Equal(deciamalBalance, Program.ViewBalanceTest(deciamalBalance));
    }

    [Theory]
    [InlineData("52", "26")]
    [InlineData("2", "34")]
    [InlineData("65", "75")]
    public void DepositT(string balance, string deposit)
    {
        var deciamalBalance = Convert.ToDecimal(balance);
        var decimalDeposit = Convert.ToDecimal(deposit);
        Assert.Equal(deciamalBalance + decimalDeposit, Program.DepositTest(deciamalBalance, decimalDeposit));
    }

    [Theory]
    [InlineData("75", "5")]
    [InlineData("100", "55")]
    public void WithdrawalTest(string balance, string withdrawal)
    {
        var deciamalBalance = Convert.ToDecimal(balance);
        var deciamalWithdrawal = Convert.ToDecimal(withdrawal);
        Assert.Equal(deciamalBalance - deciamalWithdrawal, Program.WithdrawTest(deciamalBalance, deciamalWithdrawal));
    }
}
