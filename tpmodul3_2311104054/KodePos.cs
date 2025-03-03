﻿using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePos;

    public KodePos()
    {
        kodePos = new Dictionary<string, string>
        {
            { "Batumunggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" }
        };
    }

    public string GetKodePos(string kelurahan)
    {
        if (kodePos.ContainsKey(kelurahan))
        {
            return kodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class Programm
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.WriteLine(kodePos.GetKodePos("Batumunggal")); // Output: 40266
        Console.WriteLine(kodePos.GetKodePos("Maleer"));      // Output: 40274
        Console.WriteLine(kodePos.GetKodePos("Unknown"));     // Output: Kode pos tidak ditemukan
    }
}