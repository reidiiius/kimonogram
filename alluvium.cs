
using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace Kimonogram {

  class Alluvium {

    string pitchfork;

    Hashtable digraphs = new Hashtable() {
      {"j2", "vv zq dd dd ry wu dd uw dd sx dd qz "},
      {"j3", "vt dd tv xq dd ws dd uu dd sw dd qx "},
      {"j5", "wr dd ut dd sv oq qo dd dd tu dd rw "},
      {"j6", "vu dd tw dd rx wt dd uv yq dd dd qy "},
      {"k1", "dd qx vt dd tv xq dd ws dd uu dd sw "},
      {"k2", "yr dd dd qz vv zq dd xs dd wu dd uw "},
      {"k5", "xr dd wt dd uv yq dd dd qy vu dd tw "},
      {"k6", "vs dd tu dd rw wr dd ut dd dd oq qo "},
      {"n0", "vr dd tt dd rv wq dd us dd su dd qw "},
     {"j17", "dd dd tu dd rw wr dd ut dd sv oq qo "},
     {"j23", "vv zq dd xs dd wu dd uw dd sx dd qz "},
     {"j25", "qr vp dd dd pv rq wo dd dd yu dd ow "},
     {"j26", "vv zq dd dd ry wu dd uw yr dd dd qz "},
     {"j36", "vu dd tw xr dd wt dd uv yq dd dd qy "},
     {"j56", "xr dd wt dd uv yq so dd qy dd dd tw "},
     {"k12", "dd sx dd qz vv zq dd xs dd wu dd uw "},
     {"k15", "dd rx wt dd uv yq dd dd qy vu dd tw "},
     {"k25", "yr dd dd qz vv zq dd dd ry wu dd uw "},
     {"k26", "vp dd dd pv rq wo dd uy dd dd ow qr "},
     {"k34", "wr dd ut dd dd oq qo vs dd tu dd rw "},
     {"k56", "vu dd tw dd rx wt dd dd yq dd os qy "},
    {"j236", "vv zq dd xs dd wu dd uw yr dd dd qz "},
    {"j256", "qr vp dd dd pv rq wo dd uy dd dd ow "},
    {"j2k5", "qr vp dd dd pv rq dd dd uy yu dd ow "},
    {"j2k6", "vv zq dd dd ry wu dd uw dd dd ot qz "},
    {"j2y3", "vv zq to dd dd wu dd uw dd sx dd qz "},
    {"j3k5", "yr dd ot qz dd zq dd dd ry wu dd uw "},
    {"j3k6", "vo dd ty xu dd ww dd ux dd dd ov qq "},
    {"j5y6", "wr dd ut dd sv oq qo vs dd dd dd rw "},
    {"k125", "dd sx dd qz vv zq dd dd ry wu dd uw "},
    {"k1j5", "dd ux yt dd ov qq vo dd dd xu dd ww "},
    {"k1j6", "dd zq to dd ry wu dd uw yr dd dd qz "},
    {"k256", "vp dd dd pv rq wo dd dd yu dd ow qr "},
    {"k2j5", "yr dd dd qz vv zq to dd dd wu dd uw "},
    {"k2j6", "vp dd dd pv rq wo dd uy yu dd dd qr "},
    {"k2x1", "dd dd ot qz vv zq dd xs dd wu dd uw "},
    {"k6x5", "vs dd tu dd rw wr dd dd dd sv oq qo "},
    {"n167", "yr dd dd qz dd zq to dd ry wu dd uw "},
    {"n345", "dd zq dd dd ry wu dd uw yr dd ot qz "},
    {"n5y2", "vp dd dd pv rq dd dd uy yu dd ow qr "},
    {"n6x2", "qr vp dd dd pv rq wo dd uy yu dd dd "},
   {"j17y2", "vs dd dd dd rw wr dd ut dd sv oq qo "},
   {"j23k6", "vv zq dd xs dd wu dd uw dd dd ot qz "},
   {"j25y6", "or qp dd dd tv pq ro ws dd dd dd sw "},
   {"j26y3", "vv zq to dd dd wu dd uw yr dd dd qz "},
   {"j2k34", "or qp dd dd dd pq ro ws dd uu dd sw "},
   {"j2k56", "vv zq dd dd ry wu dd dd yr dd ot qz "},
   {"j34k6", "vt dd tv pq ro dd dd uu dd dd or qp "},
   {"j56y7", "xr dd wt dd uv yq so dd qy vu dd dd "},
   {"k12j5", "dd sx dd qz vv zq to dd dd wu dd uw "},
   {"k17j5", "or qp vt dd tv pq ro dd dd uu dd dd "},
   {"k2j17", "dd dd dd pq ro ws dd uu dd sw or qp "},
   {"k25x1", "dd dd ot qz vv zq dd dd ry wu dd uw "},
   {"k26x5", "vt dd dd pq ro ws dd dd dd sw or qp "},
   {"k2j56", "yr dd dd qz vv zq to dd ry dd dd uw "},
   {"k34x2", "wr dd dd dd sv oq qo vs dd tu dd rw "},
   {"k56x4", "vu dd tw dd rx dd dd uv yq dd os qy "},
   {"n25x6", "or qp vt dd dd pq ro ws dd dd dd sw "},
   {"n26y5", "dd dd tv pq ro ws dd dd dd sw or qp "},
   {"n45y2", "vo dd dd xu dd ww dd ux yt dd ov qq "},
   {"n67x2", "dd ux dd dd ov qq vo dd ty xu dd ww "},
  {"j136y7", "dd dd tw xr dd wt dd uv yq so dd qy "},
  {"j167y2", "vu dd dd dd rx wt dd uv yq dd os qy "},
  {"j246y3", "vv zq to dd ry dd dd uw yr dd dd qz "},
  {"j26y34", "vv zq to xs dd dd dd uw yr dd dd qz "},
  {"j2k6x5", "vv zq dd dd ry wu dd dd dd sx ot qz "},
  {"j2k6y3", "vv zq to dd dd wu dd uw dd dd ot qz "},
  {"j346y5", "yr dd ot qz vv zq dd dd ry dd dd uw "},
  {"j3k5x4", "vu dd tw xr dd dd dd uv yq so dd qy "},
  {"k135x4", "dd rx wt dd dd yq dd os qy vu dd tw "},
  {"k157x6", "vv zq to dd ry wu dd dd yr dd dd qz "},
  {"k1j6y7", "dd rx wt dd uv yq dd os qy vu dd dd "},
  {"k257x1", "yr dd ot qz vv zq dd dd ry wu dd dd "},
  {"k25x17", "dd sx ot qz vv zq dd dd ry wu dd dd "},
  {"k2j5x1", "dd dd ot qz vv zq to dd dd wu dd uw "},
  {"k2j5y6", "yr dd dd qz vv zq to xs dd dd dd uw "},
  {"k345x2", "xr dd dd dd uv yq so dd qy vu dd tw "},
  {"n167x4", "vu dd dd xr dd wt dd uv yq so dd qy "},
  {"n345y7", "dd rx dd dd uv yq dd os qy vu dd tw "},
 {"j2k56x4", "vv zq dd dd ry dd dd uw yr dd ot qz "},
 {"j3k56x4", "vo dd ty xu dd dd dd ux yt dd ov qq "},
 {"k1j56y7", "dd ux yt dd ov qq vo dd ty xu dd dd "},
 {"k2j56y7", "yr dd dd qz vv zq to dd ry wu dd dd "}};


    string Retrieve(string k) {
      string s = digraphs[k].ToString();
      return s;
    }


    string Ziltch() {
      string mute, tacet;
      mute = new string('_', 36);
      tacet = mute.Replace("___", "__ ");
      return tacet;
    }


    string HoroLog() {
      string serial;
      DateTime stamp = DateTime.Now;
      serial = stamp.ToString("yyyyMMddTHHmmss");
      return serial;
    }


    string PegBox(string s, int n) {
      string head, tail;
      head = s.Substring(n, (s.Length - n));
      tail = s.Substring(0, (n + 2));
      return String.Concat(head, tail);
    }


    string Bj(string s) {
      return PegBox(s, 30);
    }


    string Fn(string s) {
      return PegBox(s, 15);
    }


    string Cn(string s) {
      return PegBox(s, 0);
    }


    string Gn(string s) {
      return PegBox(s, 21);
    }


    string Dn(string s) {
      return PegBox(s, 6);
    }


    string An(string s) {
      return PegBox(s, 27);
    }


    string En(string s) {
      return PegBox(s, 12);
    }


    string Bn(string s) {
      return PegBox(s, 33);
    }


    string Fk(string s) {
      return PegBox(s, 18);
    }


    string[] Triton(string s)
    {
      string sBn, sFn;
      sFn = Fn(s);
      sBn = Bn(s); 

      string[] a = {
        sBn,
        sFn,
        sBn, 
        sFn,
        sBn
      }; 

      return a;
    }


    string[] Cello(string s)
    {
      string[] a = {
        En(s),
        An(s),
        Dn(s),
        Gn(s),
        Cn(s)
      }; 

      return a;
    }


    string[] Guitar(string s)
    {
      string sEn = En(s);

      string[] a = {
        sEn,
        Bn(s),
        Gn(s),
        Dn(s),
        An(s),
        sEn
      }; 

      return a;
    }


    string[] Maj3rds(string s)
    {
      string sDn, sBj, sFk;
      sDn = Dn(s);
      sBj = Bj(s);
      sFk = Fk(s);
 
      string[] a = {
        sDn,
        sBj,
        sFk,
        sDn,
        sBj,
        sFk
      }; 

      return a;
    }


    string[] Ennead(string s)
    {
      string[] a = {
        Bj(s),
        Fn(s),
        Cn(s),
        Gn(s),
        Dn(s),
        An(s),
        En(s),
        Bn(s),
        Fk(s)
      }; 

      return a;
    }


    string[] Quiver(string s)
    {
      string[] a;

      switch(pitchfork)
      {
        case "bfbfb":
        case "sqrt2":
          a = Triton(s);
          break;

        case "P5":
        case "cello":
        case "cgdae":
          a = Cello(s);
          break;

        case "eadgbe":
        case "guitar":
          a = Guitar(s);
          break;
 
        case "M3":
        case "fkbjdn":
          a = Maj3rds(s);
          break;

        default:
          pitchfork = "P4";
          a = Ennead(s);
          break;
      }

      return a;
    }


    void HeadStock(string signat, string sargam, string diadem)
    {
      string[] arrows = Quiver(sargam);
      string caption = string.Format("{0}-{1}-m{2}", signat, pitchfork, diadem);

      Console.WriteLine("\t{0}", caption);

      for (int i = 0; i < arrows.Length; i++) {
        Console.WriteLine("\t{0}", arrows[i]);
      }
    }


    string[] Rummage(string signat)
    {
      int amount = digraphs.Count;
      string[] keyRing = new string[amount];

      uint i = 0;
      foreach (string token in digraphs.Keys) {
        keyRing[i] = token;
        i += 1;
      };

      Array.Sort(keyRing);

      Regex pattern = new Regex(signat);
      StringBuilder bows = new StringBuilder("", 512);

      foreach (string item in keyRing) {
        if (pattern.IsMatch(item)) {
          bows.AppendFormat("{0} ", item);
        }
      }

      string tempura = bows.ToString().Trim();
      string[] found = tempura.Split(' ');

      return found;
    }


    void ChalkBoard(string[] signs) {
      uint cycle = 0;

      Console.Write("\t");

      foreach (string item in signs) {
        if (cycle % 7 == 0 ) {
          Console.Write("\n");
        }
        Console.Write("\t{0}", item);
        cycle += 1;
      } 

      Console.WriteLine(); 
    }


    void Contingency(string signat)
    {
      Console.WriteLine("\n\t{0} ?", signat);

      string[] found = Rummage(signat);

      if (found.Length > 0 && found[0] != String.Empty)
      {
        ChalkBoard(found);
      }
    }
 

    public void LatticeWork() {
      Console.WriteLine();
      HeadStock("z0", Ziltch(), HoroLog()); 
    }


    public void LatticeWork(string[] argot) {
      string datum, sargam, diadem;
      diadem = HoroLog();

      foreach (string signat in argot)
      {
        if (digraphs.ContainsKey(signat)) {
          datum = Retrieve(signat);

          if (datum.Length < 36) {
            datum = Ziltch();
            sargam = datum.Replace('_', '-');
          }
          else {
            sargam = datum.Replace("dd", "__");
          }

          Console.WriteLine();
          HeadStock(signat, sargam, diadem);
        }
        else {
          Contingency(signat);
        }
      }
    }


    public void Neptune() {
      pitchfork = String.Empty;
    }
 

    public void Neptune(string trident) {
      if (trident == null) {
        pitchfork = String.Empty;
      }
      else {
        pitchfork = trident;
      }
    }
 

    public void Salacia() {
      string signat = "z0";
      if (!digraphs.ContainsKey(signat)) {
        digraphs.Add(signat, Ziltch());
      }
    }


    public void Salacia(string signat) {
      if (!digraphs.ContainsKey(signat)) {
        digraphs.Add(signat, String.Empty);
      }
    }


    public void Salacia(string signat, string datum) {
      if (!digraphs.ContainsKey(signat)) {
        digraphs.Add(signat, datum);
      }
    }


    public void ShowMenu() {
      uint cycle = 0;
      int recs = digraphs.Count;
      string[] clave = new string[recs];

      foreach (string item in digraphs.Keys) {
        clave[cycle] = item;
        cycle += 1;
      }

      Array.Sort(clave);

      ChalkBoard(clave);
      Console.WriteLine(); 
    }


  } // Alluvium


  class Instrument : Alluvium {

    public Instrument() {
      this.Neptune();
      this.Salacia();
    }

    public Instrument(string conch) {
      this.Neptune(conch);
      this.Salacia();
    }

  } // Instrument


} // Kimonogram


