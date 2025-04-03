using ECR;
using PosServer.Application.Exceptions;
using Serilog;


namespace PosServer.Implementation.Ecr
{
    public class EcrConnector
    {
        public async Task<PaymentResult> ExecuteTransactionAsync(TransParamsV3 tp, string ipAdress)
        {
            EcrPort.RawdataEvent += EcrPort_RawdataEvent;
            EcrPort.EcrExtendedMessageReceived += EcrPort_EcrExtendedMessageReceived;
            EcrPort.EcrMessageReceived += EcrPort_EcrMessageReceived;
            EcrPort.EcrFunctionMessageReceived += EcrPort_EcrFunctionMessageReceived;
            EcrPort.EcrAs24MessageReceived += EcrPort_EcrAs24MessageReceived;

            try
            {
                Log.Information("Starting ECR communication.");

                int responce = await Task.Factory.StartNew(() => EcrPort.DoTransactionTcp(ref tp, ipAdress));

                Log.Information("ECR communication finished.");

                return new PaymentResult { ResponceCode = responce, TransParams = tp, DccData = tp.ReturnDccData(), Total = tp.getTotalsNew(), TransDet = tp.getAllTransactions() };
            }
            catch (Exception ex)
            {
                throw new EcrException($"Dll greška: {ex.Message}. {ex.InnerException?.Message}");
            }
            finally
            {
                EcrPort.RawdataEvent -= EcrPort_RawdataEvent;
                EcrPort.EcrExtendedMessageReceived -= EcrPort_EcrExtendedMessageReceived;
                EcrPort.EcrMessageReceived -= EcrPort_EcrMessageReceived;
                EcrPort.EcrFunctionMessageReceived -= EcrPort_EcrFunctionMessageReceived;
                EcrPort.EcrAs24MessageReceived -= EcrPort_EcrAs24MessageReceived;
            }
        }

        private void EcrPort_EcrAs24MessageReceived(string messageIdentifier, string track2data, string message, string bfoc)
        {
            //Log.Write(localContextId, localTID, $"As24 message received > Message identifier : {messageIdentifier} - Track to data : {track2data} - Message : {message} - Bfoc : {bfoc}", Direction.PosToServer);
        }
        private void EcrPort_EcrFunctionMessageReceived(string messageIdentifier, string code, string message)
        {
            //Log.Write(localContextId, localTID, $"Ecr Function message received > Message identifier : {messageIdentifier} - Code : {code} - Message : {message}", Direction.PosToServer);
        }
        private void EcrPort_EcrMessageReceived(string messageIdentifier, string message)
        {
            //Log.Write(localContextId, localTID, $"Ecr message received > Message identifier : {messageIdentifier} - Message : {message}", Direction.PosToServer);
        }
        private void EcrPort_EcrExtendedMessageReceived(string messageIdentifier, string code, string message)
        {
            //Log.Write(localContextId, localTID, $"Ecr extended message received > Message identifier : {messageIdentifier} - Code : {code} - Message : {message}", Direction.PosToServer);
        }
        private void EcrPort_RawdataEvent(EcrPort.DataDirection direction, byte[] rawdata)
        {
            //Log.Write(localContextId, localTID, $"Ecr raw data message received > Raw data : {rawdata} - Ecr port data direction : {direction}", Direction.PosToServer);
        }
    }
}
