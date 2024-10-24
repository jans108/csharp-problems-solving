using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];

        buffer[0] = 0xf8;

        var toBite = BitConverter.GetBytes(reading);

        Array.Copy(toBite, 0, buffer, 1, toBite.Length);

        return buffer;
    }

    public static byte[] ToBuffer(uint reading)
    {
        byte[] buffer = new byte[9];

        buffer[0] = 0x4;

        var toBite = BitConverter.GetBytes(reading);

        Array.Copy(toBite, 0, buffer, 1, toBite.Length);

        return buffer;
    }

    public static byte[] ToBuffer(int reading)
    {
        byte[] buffer = new byte[9];

        buffer[0] = 0xfc;

        var toBite = BitConverter.GetBytes(reading);

        Array.Copy(toBite, 0, buffer, 1, toBite.Length);

        return buffer;
    }

    public static byte[] ToBuffer(ushort reading)
    {
        byte[] buffer = new byte[9];

        buffer[0] = 0x2;

        var toBite = BitConverter.GetBytes(reading);

        Array.Copy(toBite, 0, buffer, 1, toBite.Length);

        return buffer;
    }

    public static byte[] ToBuffer(short reading)
    {
        byte[] buffer = new byte[9];

        if (reading < 0)
            buffer[0] = 0xfe;
        else
        {
            buffer[0] = 0x2;
        }

        var toBite = BitConverter.GetBytes(reading);

        Array.Copy(toBite, 0, buffer, 1, toBite.Length);

        return buffer;
    }



    public static long FromBuffer(byte[] buffer)
    {
        throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
    }
}
