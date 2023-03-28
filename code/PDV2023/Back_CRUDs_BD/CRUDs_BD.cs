
namespace Back_CRUDs_BD;

public abstract class CRUDs_BD
{
    protected string connectionString;
    private DBMS dbms;
    protected string tabla;
    protected List<string> campos = new List<string>();
    protected List<string> valores = new List<string>();
    //vars para el connectionSTring
    protected string host;
    protected string us;
    protected string pwd;
    protected string puerto;
    protected string nombreBD;
    /// <summary>
    /// Para definir los criterios de búsqueda que se aplicarán en un SELECT, en la parte del WHERE. P.Ej:
    /// SELECT * FROM usuarios WHERE [criteriosBusqueda]
    /// SELECT * FROM usuarios WHERE [email="ivanna@hotmail.com"] AND [password='123123123']
    /// </summary>
    protected string criteriosBusqueda;
    /// <summary>
    /// Nos permite establecer el ORDER BY, GROUP BY, o LIMIT
    /// Para personalizar la búsqueda.
    /// P.EJ.
    /// SELECT * FROM usuarios WHERE nombre LIKE '%I%' ORDER BY id DESC LIMIT 20
    /// </summary>
    protected string ordenGruposLimit;
    /// <summary>
    /// Mensaje de ERror para consultarse en cualquier parte y momento de la app
    /// </summary>
    public string msgError;

    public object dr;

    /////-----------METODOS---------------////
    public abstract bool insertar(string tabla, List<string> campos, List<ValoresAInsertar> valores);
    public abstract bool modificar(string tabla, List<string> campos, List<ValoresAInsertar> valores, int id);
    public abstract bool borrar(string tabla, int id);
    public abstract List<object[]> consulta(string tabla);
    public abstract List<object[]> consulta(string tabla, string criterioBusqueda);

    public abstract object consulta1SoloValor(string campo, string tabla, string criterioBusqueda);

}

