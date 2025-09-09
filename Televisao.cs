public class Televisao
{
    private const int CanalMaximo = 520;
    private const int VolumeMaximo = 100;

    private int canalAtual;
    private int ultimoCanal;
    private int volumeAtual;
    private bool mudo;

    public Televisao()
    {
        canalAtual = 1; 
        ultimoCanal = 1;
        volumeAtual = 50; 
        mudo = false;
    }

    // === Canais ===
    public void Ligar()
    {
        canalAtual = ultimoCanal;
        Console.WriteLine($"TV ligada no canal {canalAtual}");
    }

    public void Desligar()
    {
        ultimoCanal = canalAtual; 
        Console.WriteLine("TV desligada");
    }

    public void ProximoCanal()
    {
        if (canalAtual < CanalMaximo)
            canalAtual++;
        else
            canalAtual = 1; 

        ultimoCanal = canalAtual;
    }

    public void CanalAnterior()
    {
        if (canalAtual > 1)
            canalAtual--;
        else
            canalAtual = CanalMaximo; 

        ultimoCanal = canalAtual;
    }

    public void IrParaCanal(int numero)
    {
        if (numero < 1 || numero > CanalMaximo)
        {
            Console.WriteLine("Canal inválido!");
            return;
        }

        canalAtual = numero;
        ultimoCanal = numero;
    }

    public int CanalAtual => canalAtual;

    // Volume
    public void AumentarVolume()
    {
        if (!mudo && volumeAtual < VolumeMaximo)
            volumeAtual++;
    }

    public void DiminuirVolume()
    {
        if (!mudo && volumeAtual > 0)
            volumeAtual--;
    }

    public void AtivarMudo()
    {
        mudo = true;
    }

    public void DesativarMudo()
    {
        mudo = false;
    }

    public int VolumeAtual => mudo ? 0 : volumeAtual;

    public bool EstaMudo => mudo;
}
