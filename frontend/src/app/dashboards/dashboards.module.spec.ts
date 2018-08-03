import { DashboardsModule } from './dashboards.module';

describe('DashboardsModule', () => {
  let dashboardsModule: DashboardsModule;

  beforeEach(() => {
    dashboardsModule = new DashboardsModule();
  });

  it('should create an instance', () => {
    expect(dashboardsModule).toBeTruthy();
  });
});
