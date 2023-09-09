using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class TerminalCmd : ITerminalCmd
    {
        private readonly IBldc bldc;

        public TerminalCmd(IBldc bldc)
        {
            this.bldc = bldc;
        }

        public void Help()
        {
            bldc.TerminalCmd("help");
        }

        public void Ping()
        {
            bldc.TerminalCmd("ping");
        }

        public void Stop()
        {
            bldc.TerminalCmd("stop");
        }

        public void LastAdcDuration()
        {
            bldc.TerminalCmd("last_adc_duration");
        }

        public void Kv()
        {
            bldc.TerminalCmd("kv");
        }

        public void Mem()
        {
            bldc.TerminalCmd("mem");
        }

        public void Threads()
        {
            bldc.TerminalCmd("threads");
        }

        public void Fault()
        {
            bldc.TerminalCmd("fault");
        }

        public void Faults()
        {
            bldc.TerminalCmd("faults");
        }

        public void Rpm()
        {
            bldc.TerminalCmd("rpm");
        }

        public void Tacho()
        {
            bldc.TerminalCmd("tacho");
        }

        public void Dist()
        {
            bldc.TerminalCmd("dist");
        }

        public void Tim()
        {
            bldc.TerminalCmd("tim");
        }

        public void Volt()
        {
            bldc.TerminalCmd("volt");
        }

        public void ParamDetect(float current, int minRpm, float lowDuty)
        {
            bldc.TerminalCmd($"param_detect {current} {minRpm} {lowDuty}");
        }

        public void RpmDep()
        {
            bldc.TerminalCmd("rpm_dep");
        }

        public void CanDevs()
        {
            bldc.TerminalCmd("can_devs");
        }

        public void FocEncoderDetect(float current)
        {
            bldc.TerminalCmd($"foc_encoder_detect {current}");
        }

        public void MeasureRes(float current)
        {
            bldc.TerminalCmd($"measure_res {current}");
        }

        public void MeasureInd(float duty)
        {
            bldc.TerminalCmd($"measure_ind {duty}");
        }

        public void MeasureLinkage(float current, float duty, float minErpm, float motorRes)
        {
            bldc.TerminalCmd($"measure_linkage {current} {duty} {minErpm} {motorRes}");
        }

        public void MeasureResInd()
        {
            bldc.TerminalCmd("measure_res_ind");
        }

        public void MeasureLinkageFoc(float duty)
        {
            bldc.TerminalCmd($"measure_linkage_foc {duty}");
        }

        public void MeasureLinkageOpenloop(float current, float duty, int erpmPerSec, float motorRes, float motorInd)
        {
            bldc.TerminalCmd($"measure_linkage_openloop {current} {duty} {erpmPerSec} {motorRes} {motorInd}");
        }

        public void FocState()
        {
            bldc.TerminalCmd("foc_state");
        }

        public void FocDcCal()
        {
            bldc.TerminalCmd("foc_dc_cal");
        }

        public void HwStatus()
        {
            bldc.TerminalCmd("hw_status");
        }

        public void FocOpenloop(float current, int erpm)
        {
            bldc.TerminalCmd($"foc_openloop {current} {erpm}");
        }

        public void FocOpenloopDuty(float duty, int erpm)
        {
            bldc.TerminalCmd($"foc_openloop_duty {duty} {erpm}");
        }

        public void NrfExtSetEnabled(bool enabled)
        {
            bldc.TerminalCmd($"nrf_ext_set_enabled {enabled}");
        }

        public void FocSensorsDetectApply(float current)
        {
            bldc.TerminalCmd($"foc_sensors_detect_apply {current}");
        }

        public void RotorLockOpenloop(float currentA, int timeS, float angleDeg)
        {
            bldc.TerminalCmd($"rotor_lock_openloop {currentA} {timeS} {angleDeg}");
        }

        public void FocDetectApplyAll(float maxPowerLossW)
        {
            bldc.TerminalCmd($"foc_detect_apply_all {maxPowerLossW}");
        }

        public void CanScan()
        {
            bldc.TerminalCmd("can_scan");
        }

        public void FocDetectApplyAllCan(float maxPowerLossW)
        {
            bldc.TerminalCmd($"foc_detect_apply_all_can {maxPowerLossW}");
        }

        public void Encoder()
        {
            bldc.TerminalCmd("encoder");
        }

        public void EncoderClearErrors()
        {
            bldc.TerminalCmd("encoder_clear_errors");
        }

        public void EncoderClearMultiturn()
        {
            bldc.TerminalCmd("encoder_clear_multiturn");
        }

        public void Uptime()
        {
            bldc.TerminalCmd("uptime");
        }

        public void HallAnalyze(float current)
        {
            bldc.TerminalCmd($"hall_analyze {current}");
        }

        public void IoBoardSetOutput(int id, int ch, int state)
        {
            bldc.TerminalCmd($"io_board_set_output {id} {ch} {state}");
        }

        public void IoBoardSetOutputPwm(int id, int ch, int duty)
        {
            bldc.TerminalCmd($"io_board_set_output_pwm {id} {ch} {duty}");
        }

        public void Crc()
        {
            bldc.TerminalCmd("crc");
        }

        public void DrvResetFaults()
        {
            bldc.TerminalCmd("drv_reset_faults");
        }

        public void UpdatePidPosOffset(float angleNow, int store)
        {
            bldc.TerminalCmd($"update_pid_pos_offset {angleNow} {store}");
        }

        public void Events()
        {
            bldc.TerminalCmd("events");
        }

        public void ConnectVirtualMotor(int ml, int J, int vBus)
        {
            bldc.TerminalCmd($"connect_virtual_motor {ml} {J} {vBus}");
        }

        public void DisconnectVirtualMotor()
        {
            bldc.TerminalCmd("disconnect_virtual_motor");
        }

        public void FocTmp()
        {
            bldc.TerminalCmd("foc_tmp");
        }

        public void FocPlotHfiEn(float en)
        {
            bldc.TerminalCmd($"foc_plot_hfi_en {en}");
        }

        public void UavcanDebug(int level)
        {
            bldc.TerminalCmd($"uavcan_debug {level}");
        }

        public void NunchukStatus()
        {
            bldc.TerminalCmd("nunchuk_status");
        }

        public void BmSwdpScan()
        {
            bldc.TerminalCmd("bm_swdp_scan");
        }

        public void BmAttach(int index)
        {
            bldc.TerminalCmd($"bm_attach {index}");
        }

        public void BmFlashErase(string hexAddr, int len)
        {
            bldc.TerminalCmd($"bm_flash_erase {hexAddr} {len}");
        }

        public void BmTargetHelp()
        {
            bldc.TerminalCmd("bm_target_help");
        }

        public void BmTargetCmd(string cmd)
        {
            bldc.TerminalCmd($"bm_target_cmd {cmd}");
        }

        public void BmReset()
        {
            bldc.TerminalCmd("bm_reset");
        }

        public void BmDetach()
        {
            bldc.TerminalCmd("bm_detach");
        }

        public void AppBalanceExperiment(int fieldNumber, int plot)
        {
            bldc.TerminalCmd($"app_balance_experiment {fieldNumber} {plot}");
        }
    }
}
