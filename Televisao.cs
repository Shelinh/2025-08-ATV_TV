public class Televisao
{
    private const int CanalMaximo = 520;
    private const int VolumeMaximo = 100;

    private int canalAtual;
    private int ultimoCanal;
    private int volumeAtual;
    private bool mudo;

    public float Tamanho { get; set; }

    public int Volume
    {
        get => mudo ? 0 : volumeAtual;
        set
        {
            if (value < 0)
                volumeAtual = 0;
            else if (value > VolumeMaximo)
                volumeAtual = VolumeMaximo;
            else
                volumeAtual = value;
        }
    }

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        canalAtual = 1;
        ultimoCanal = 1;
        volumeAtual = 50;
        mudo = false;
    }

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

    public void AtivarMudo() => mudo = true;
    public void DesativarMudo() => mudo = false;

    public bool EstaMudo => mudo;
}
