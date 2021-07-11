# C\# 메모리릭 찾기 \(.NET Framework\)

* 프로세스 덤프

![](.gitbook/assets/image%20%281%29%20%281%29%20%281%29.png)

* 덤프 파일 복사

![](.gitbook/assets/image.png)

![](.gitbook/assets/image%20%282%29.png)

* Windbg Preview 설치

![](.gitbook/assets/image%20%283%29.png)

* WinDbg 실행
* dump 파일 열기

![](.gitbook/assets/image%20%284%29.png)

![](.gitbook/assets/image%20%285%29.png)

* !analyze -v
  * 시간이 걸립니다.

![](.gitbook/assets/image%20%287%29.png)

* !dumpheap -stat
  * 관리되는 힙을 출력합니다.
  * 메모리가 많이 소요되는 object type을 찾습니다.

![](.gitbook/assets/image%20%286%29.png)



* !dumpheap /d -mt 00007ffe9a0159c0
  * object가 관리되는 heap에 할당된 주소를 가져옵니다.

![](.gitbook/assets/image%20%281%29.png)

* !gcroot 000000002e7510a0
  * 해당 object를 참조하는 object를 표시합니다.
  * 객체 할당과 연관된 class를 추론할 수 있습니다.

![](.gitbook/assets/image%20%288%29.png)



