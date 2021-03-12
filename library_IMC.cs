
namespace library_IMC
{
    public class libary_IMC
    {
        public static string R_IMC(float IMC)
        {
            if (IMC >16 && IMC <= 16.9)
            {
                return "Você está muito abaixo do peso, procure um médico!";
            }
            if (IMC >17 && IMC <= 18.4)
            {
                return "Você está abaixo do peso, tome cuidado!";
            }
            if (IMC >18.5 && IMC <= 24.9)
            {
                return "Você está no peso ideal para a sua altura!";
            }
            if (IMC >25 && IMC <= 29.9)
            {
                return "Você está acima do peso, tome cuidado!";
            }
            if (IMC >30 && IMC <= 34.4)
            {
                return "Você está com obesidade grau I, procure um especialista!";
            }
            if (IMC >35 && IMC <= 40)
            {
                return "Você está com obesidade grau II, procure um especilista o mais rápido possível!";
            }
            if (IMC >40)
            {
                return "Você está com obesidade grau III e está em nível crítico, procure um especialista urgente!";
            }
            else return "Talvez você não tenha inserido um valor válido! Tente novamente.";
        }
    }
}
